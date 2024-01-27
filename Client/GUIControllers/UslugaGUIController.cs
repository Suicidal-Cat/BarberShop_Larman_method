using Client.UserControls;
using Client.UserControls.UCUsluga;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUIControllers
{
	internal class UslugaGUIController
	{
		private UCSingleUsluga uCUsluga;
		private UCSearchUsluga uCSearchUsluga;

		internal Control CreateUCUsluga(UCMode mode, Usluga usluga = null)
		{
			uCUsluga = new UCSingleUsluga();
			PrepareFormUsluga(mode,usluga);
			if (mode == UCMode.Add)
			{
				uCUsluga.btnSave.Click += SacuvajUslugu;
				uCUsluga.btnBack.Click+= (s, e) => MainCoordinator.Instance.ShowDefault();
			}
			else if (mode == UCMode.Update || mode==UCMode.Show)
			{
				uCUsluga.btnBack.Click += (s, e) => MainCoordinator.Instance.ShowSearchUsluge();
				if (mode == UCMode.Update) uCUsluga.btnSave.Click += AzurirajUslugu;
			}
			return uCUsluga;
		}

		private void AzurirajUslugu(object sender, EventArgs e)
		{
			Usluga usluga = new Usluga
			{
				IdUsluge=int.Parse(uCUsluga.lblIdUsluge.Text),
				NazivUsluge = uCUsluga.txtNaziv.Text.Trim(),
				CenaUsluge = int.Parse(uCUsluga.txtCena.Text.Trim()),
				TrajanjeUslugeUMinutima = int.Parse(uCUsluga.txtTrajanje.Text.Trim()),
			};
			Response res=Communication.Instance.IzmeniUslugu(usluga);
			MessageBox.Show(res.Message);
		}

		internal Control CreateUCSearchUsluga()
		{
			uCSearchUsluga = new UCSearchUsluga();
			uCSearchUsluga.Load +=(s,e) => VratiSveUsluge();
			uCSearchUsluga.btnSearch.Click += PretraziPoImenuUsluge;
			uCSearchUsluga.btnShow.Click += PrikaziTrazenuUslugu;
			uCSearchUsluga.btnEdit.Click += PrikaziUsluguZaIzmenu;
			uCSearchUsluga.btnDelete.Click += IzbrisiIzabranuUslugu;
			uCSearchUsluga.btnBack.Click += (s, e) => MainCoordinator.Instance.ShowDefault();
			return uCSearchUsluga;
		}

		private void IzbrisiIzabranuUslugu(object sender, EventArgs e)
		{
			Usluga usluga = VratiTrazenuUslugu();
			if (usluga == null)
			{
				MessageBox.Show("Izaberite neku od usluga iz liste");
				return;
			}
			Response res=Communication.Instance.IzbrisiUslugu(usluga);
			uCSearchUsluga.btnSearch.PerformClick();
			MessageBox.Show(res.Message);
		}

		private void PrikaziUsluguZaIzmenu(object sender, EventArgs e)
		{
			Usluga usluga = VratiTrazenuUslugu();
			if (usluga == null)
			{
				MessageBox.Show("Izaberite neku od usluga iz liste");
				return;
			}
			MainCoordinator.Instance.ShowUslugaPanel(UCMode.Update, usluga);
		}

		private void PrikaziTrazenuUslugu(object sender, EventArgs e)
		{
			Usluga usluga = VratiTrazenuUslugu();
			if (usluga == null)
			{
				MessageBox.Show("Izaberite neku od usluga iz liste");
				return;
			}
			MainCoordinator.Instance.ShowUslugaPanel(UCMode.Show, usluga);
		}

		private Usluga VratiTrazenuUslugu()
		{
			if (uCSearchUsluga.listbUsluge.SelectedItems.Count == 1)
			{
				string name = ((ListBoxUsluga)uCSearchUsluga.listbUsluge.SelectedItem).NazivUsluge;
				/*Usluga u = uCSearchUsluga.Usluge.First(usl => usl.NazivUsluge == name);*/
				Usluga u=new Usluga();
				foreach(ListBoxUsluga lb in uCSearchUsluga.listbUsluge.Items)
				{
					if (lb.NazivUsluge == name)
					{
						u.IdUsluge = lb.IdUsluge;
						u.NazivUsluge=lb.NazivUsluge;
					}
				}
				return Communication.Instance.NadjiUsluguPoId(u);

			}
			else
			{
				return null;
			}
		}

		private void PretraziPoImenuUsluge(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(uCSearchUsluga.txtSearch.Text)) VratiSveUsluge();
			else
			{
				List<Usluga> usluge = Communication.Instance.PretraziPoImenuUsluge(uCSearchUsluga.txtSearch.Text);
				if (usluge == null || usluge.Count() == 0)
				{
					MessageBox.Show("Sistem nije uspeo da pronadje usluge");
					return;
				}
				uCSearchUsluga.listbUsluge.DataSource = null;
				List<ListBoxUsluga>listaUsluga= new List<ListBoxUsluga>();
				foreach (Usluga u in usluge)
				{
					ListBoxUsluga lb = new ListBoxUsluga()
					{
						IdUsluge=u.IdUsluge,
						NazivUsluge=u.NazivUsluge,
					};
					listaUsluga.Add(lb);
				}
				uCSearchUsluga.listbUsluge.DataSource = listaUsluga;
				uCSearchUsluga.listbUsluge.DisplayMember = "NazivUsluge";
			}
		}

		private void VratiSveUsluge()
		{
			List<Usluga> usluge = Communication.Instance.PretraziSveUsluge();
			if (usluge == null || usluge.Count() == 0)
			{
				MessageBox.Show("Sistem nije uspeo da pronadje usluge");
				return;
			}
			uCSearchUsluga.listbUsluge.DataSource = null;
			List<ListBoxUsluga> listaUsluga = new List<ListBoxUsluga>();
			foreach (Usluga u in usluge)
			{
				ListBoxUsluga lb = new ListBoxUsluga()
				{
					IdUsluge = u.IdUsluge,
					NazivUsluge = u.NazivUsluge,
				};
				listaUsluga.Add(lb);
			}
			uCSearchUsluga.listbUsluge.DataSource = listaUsluga;
			uCSearchUsluga.listbUsluge.DisplayMember = "NazivUsluge";
		}

		private void SacuvajUslugu(object sender, EventArgs e)
		{
			if (!ValidateUsluga()) return;
			Usluga usluga = new Usluga
			{
				NazivUsluge=uCUsluga.txtNaziv.Text.Trim(),
				CenaUsluge = int.Parse(uCUsluga.txtCena.Text.Trim()),
				TrajanjeUslugeUMinutima = int.Parse(uCUsluga.txtTrajanje.Text.Trim()),
			};
			Response res=Communication.Instance.DodajUslugu(usluga);
			MessageBox.Show(res.Message);
			ResetForm();
		}

		internal bool ValidateUsluga()
		{
			List<string> errors = new List<string>();
			List<Control>controls = new List<Control>();

			if (string.IsNullOrEmpty(uCUsluga.txtNaziv.Text) || uCUsluga.txtNaziv.Text.Length < 2 || !uCUsluga.txtNaziv.Text.All(c=> char.IsLetter(c) || char.IsWhiteSpace(c)))
			{
                Console.WriteLine("DA "+!uCUsluga.txtNaziv.Text.All(char.IsLetter));
                errors.Add("Naziv mora imati barem 2 slova i mora se sastojati samo od slova!");
				controls.Add(uCUsluga.txtNaziv);
			}
			if(string.IsNullOrEmpty(uCUsluga.txtCena.Text) || !int.TryParse(uCUsluga.txtCena.Text,out int cena) || cena<=0)
			{
				errors.Add("Cena mora biti pozitivna i predstavljati broj!");
				controls.Add(uCUsluga.txtCena);
			}
			if (string.IsNullOrEmpty(uCUsluga.txtTrajanje.Text) || !int.TryParse(uCUsluga.txtTrajanje.Text, out int trajanje) || trajanje <= 0)
			{
				errors.Add("Vreme trajanje usluge mora biti pozitivno i predstavljati broj!");
				controls.Add(uCUsluga.txtTrajanje);
			}
			if (errors.Count > 0)
			{
				ShowErrors(errors, controls);
				return false;
			}

			return true;
		}
		private void PrepareFormUsluga(UCMode mode, Usluga usluga = null)
		{
			if (mode == UCMode.Show)
			{
				uCUsluga.txtCena.Enabled = false;
				uCUsluga.txtNaziv.Enabled = false;
				uCUsluga.txtTrajanje.Enabled = false;
				uCUsluga.btnSave.Enabled = false;

				uCUsluga.txtNaziv.Text = usluga.NazivUsluge.ToString();
				uCUsluga.txtCena.Text = usluga.CenaUsluge.ToString();
				uCUsluga.txtTrajanje.Text = usluga.TrajanjeUslugeUMinutima.ToString();
			}
			else if (mode == UCMode.Update)
			{
				uCUsluga.lblIdUsluge.Text = usluga.IdUsluge.ToString();
				uCUsluga.txtNaziv.Text = usluga.NazivUsluge.ToString();
				uCUsluga.txtCena.Text = usluga.CenaUsluge.ToString();
				uCUsluga.txtTrajanje.Text = usluga.TrajanjeUslugeUMinutima.ToString();
			}
		}
		internal void ResetForm()
		{
			uCUsluga.txtCena.Text = string.Empty;
			uCUsluga.txtNaziv.Text = string.Empty;
			uCUsluga.txtTrajanje.Text = string.Empty;
			uCUsluga.txtNaziv.BackColor = Color.White;
			uCUsluga.txtCena.BackColor = Color.White;
			uCUsluga.txtTrajanje.BackColor = Color.White;
		}
		private void ShowErrors(List<string> errors, List<Control> controls)
		{
			uCUsluga.txtNaziv.BackColor = Color.White;
			uCUsluga.txtCena.BackColor = Color.White;
			uCUsluga.txtTrajanje.BackColor = Color.White;

			string errorMessage = "";
			if (errors.Count() == 0) return;
			for (int i = 0; i < controls.Count(); i++)
			{
				errorMessage += errors[i] + "\n";
				controls[i].BackColor = Color.LightSalmon;
			}

			MessageBox.Show(errorMessage);
		}
	}
	public class ListBoxUsluga
	{
		public int IdUsluge { get; set; }
		public string NazivUsluge { get; set; }
	}
}
