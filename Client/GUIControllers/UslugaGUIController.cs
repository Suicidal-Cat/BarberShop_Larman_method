using Client.UserControls;
using Client.UserControls.UCUsluga;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
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
			uCUsluga = new UCSingleUsluga(mode, usluga);
			if (mode == UCMode.Add)
			{
				uCUsluga.btnSave.Click += SacuvajUslugu;
				uCUsluga.btnBack.Click+= (s, e) => MainCoordinator.Instance.ShowDefault();
			}
			else if (mode == UCMode.Update || mode==UCMode.Show)
			{
				uCUsluga.btnSave.Click += PrikaziTrazenuUslugu;
			}
			return uCUsluga;
		}
		internal Control CreateUCSearchUsluga()
		{
			uCSearchUsluga = new UCSearchUsluga();
			uCSearchUsluga.Load += VratiSveUsluge;
			return uCSearchUsluga;
		}

		private void VratiSveUsluge(object sender, EventArgs e)
		{
			List<Usluga> usluge = Communication.Instance.PretraziSveUsluge();
			if (usluge == null || usluge.Count() == 0) MessageBox.Show("Sistem nije uspeo da pronadje usluge");
			uCSearchUsluga.Usluge = usluge;
			uCSearchUsluga.listbUsluge.Items.Clear();
			foreach (Usluga u in usluge)
			{
				uCSearchUsluga.listbUsluge.Items.Add(u.NazivUsluge);
			}
		}

		private void PrikaziTrazenuUslugu(object sender, EventArgs e)
		{
			if (!ValidateUsluga()) return;
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
			uCUsluga.resetForm();
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
				uCUsluga.ShowErrors(errors, controls);
				return false;
			}

			return true;
		}
	}
}
