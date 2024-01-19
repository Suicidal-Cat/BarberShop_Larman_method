using Client.UserControls;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUIControllers
{
	internal class FrizerGUIController
	{
		private UCSingleFrizer uCFrizer;
		private UCIzmeniFrizera uCIzmenaFrizera;

		internal Control CreateUCFrizer(UCMode mode,Frizer frizer=null)
		{
			uCFrizer = new UCSingleFrizer(mode,frizer);
			if (mode == UCMode.Add)
			{
				uCFrizer.btnSacuvajFrizera.Click += DodajFrizera;
				uCFrizer.btnBack.Click += (s, e) => MainCoordinator.Instance.ShowDefault();
			}
			else if (mode == UCMode.Update)
			{
				uCFrizer.btnSacuvajFrizera.Click += SacuvajIzmeneFrizera;
				uCFrizer.btnBack.Click += (s, e) => MainCoordinator.Instance.ShowSearchFrizera();
			}
			return uCFrizer;
		}
		internal Control CreateUCIzmeniFrizera()
		{
			uCIzmenaFrizera = new UCIzmeniFrizera();
			uCIzmenaFrizera.Load += PretraziSveFrizere;
			uCIzmenaFrizera.btnSearch.Click += PretraziPoImenuFrizere;
			uCIzmenaFrizera.btnEdit.Click += PrikaziFormuZaIzmenu;
			uCIzmenaFrizera.btnBack.Click += (s, e) =>MainCoordinator.Instance.ShowDefault();
			return uCIzmenaFrizera;
		}
		private void SacuvajIzmeneFrizera(object sender, EventArgs e)
		{
			if (!ValidationDodajFrizera()) return;
			Frizer frizer = new Frizer()
			{
				IdFrizera = uCFrizer.Frizer.IdFrizera,
				Ime = uCFrizer.txtIme.Text.Trim().Replace(" ", ""),
				Prezime = uCFrizer.txtPrezime.Text.Trim().Replace(" ", ""),
				PolFrizera = (Pol)uCFrizer.cbPol.SelectedItem,
				BrojTelefona = uCFrizer.txtBrTelfona.Text.Trim().Replace(" ", ""),
				Status = (Status)uCFrizer.cbStatus.SelectedItem,
				DatumZaposlenja = DateTime.Parse(uCFrizer.txtDatumZaposlenja.Text),
			};
			Response res = Communication.Instance.IzmeniFrizera(frizer);
			MessageBox.Show(res.Message);

		}

		private void PrikaziFormuZaIzmenu(object sender, EventArgs e)
		{
			if (uCIzmenaFrizera.dgvFrizer.SelectedCells.Count == 1 || uCIzmenaFrizera.dgvFrizer.SelectedRows.Count==1)
			{
				int id;
				if (uCIzmenaFrizera.dgvFrizer.SelectedCells.Count == 1)
				{
					int index = uCIzmenaFrizera.dgvFrizer.SelectedCells[0].RowIndex;
					id = int.Parse(uCIzmenaFrizera.dgvFrizer.Rows[index].Cells[0].Value.ToString());
				}
				else
				{
					id=int.Parse(uCIzmenaFrizera.dgvFrizer.SelectedRows[0].Cells[0].Value.ToString());
				}
				Frizer f = Communication.Instance.NadjiFrizeraPoId(id);
				MainCoordinator.Instance.ShowFrizerPanel(UCMode.Update,f);
			}
			else uCIzmenaFrizera.ShowMessage("Prvo izaberite red/celiju frizera iz tabele kojeg zelite da promenite");
		}

		private void PretraziPoImenuFrizere(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(uCIzmenaFrizera.txtSearch.Text))
			{
				List<Frizer> frizeri = Communication.Instance.PretraziPoImenuFrizere(uCIzmenaFrizera.txtSearch.Text);
				if (frizeri == null || frizeri.Count() == 0)
				{
					MessageBox.Show("Sistem nije uspeo da pronadje frizere");
					return;
				}
				else uCIzmenaFrizera.prepareDgv(frizeri);
			}
			else
			{
				List<Frizer> frizeri = Communication.Instance.PretraziSveFrizere();
				if (frizeri == null || frizeri.Count() == 0)
				{
					MessageBox.Show("Sistem nije uspeo da pronadje frizere");
					return;
				}
				else uCIzmenaFrizera.prepareDgv(frizeri);
			}
			
		}

		private void PretraziSveFrizere(object sender, EventArgs e)
		{
			List<Frizer> frizeri = Communication.Instance.PretraziSveFrizere();
			uCIzmenaFrizera.prepareDgv(frizeri);
		}

		
		private void DodajFrizera(object sender, EventArgs e)
		{
			if (!ValidationDodajFrizera()) return;
			Frizer frizer = new Frizer()
			{
				Ime = uCFrizer.txtIme.Text.Trim().Replace(" ", ""),
				Prezime = uCFrizer.txtPrezime.Text.Trim().Replace(" ", ""),
				PolFrizera = (Pol)uCFrizer.cbPol.SelectedItem,
				BrojTelefona = uCFrizer.txtBrTelfona.Text.Trim().Replace(" ", ""),
				Status = (Status)uCFrizer.cbStatus.SelectedItem,
				DatumZaposlenja=DateTime.Parse(uCFrizer.txtDatumZaposlenja.Text),
			};
			Response response = Communication.Instance.DodajFrizera(frizer);
			uCFrizer.ShowMessage(response.Message);
			uCFrizer.ResetForm();
		}
		private bool ValidationDodajFrizera()
		{
			List<string> errors = new List<string>();
			List<Control> controls = new List<Control>();

			if (string.IsNullOrEmpty(uCFrizer.txtIme.Text) || uCFrizer.txtIme.Text.Length < 2 || !uCFrizer.txtIme.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
			{
				errors.Add("Ime mora imati barem 2 slova i mora se sastojati samo od slova!");
				controls.Add(uCFrizer.txtIme);
			}

			if (string.IsNullOrEmpty(uCFrizer.txtPrezime.Text) || uCFrizer.txtIme.Text.Length < 2 || !uCFrizer.txtIme.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
			{
				errors.Add("Prezime mora imati barem 2 slova i mora se sastojati od slova!");
				controls.Add(uCFrizer.txtPrezime);
			}

			if (uCFrizer.cbPol.SelectedIndex < 0)
			{
				errors.Add("Molim vas izaberite pol frizera");
				controls.Add(uCFrizer.cbPol);
			}

			string pattern = @"^\+(381|387|382|385)([1-9][0-9]{0,2})?([0-9]{6,7})$";
			string brTelefona = uCFrizer.txtBrTelfona.Text.Replace(" ","");
            if (string.IsNullOrEmpty(uCFrizer.txtBrTelfona.Text) || !Regex.IsMatch(brTelefona, pattern))
			{
				errors.Add("Molim vas unesite broj telefona u ispravnom formatu +38XXXXXXXXXX");
				controls.Add(uCFrizer.txtBrTelfona);
			}

			if (uCFrizer.cbStatus.SelectedIndex < 0)
			{
				errors.Add("Status ne moze biti prazan!");
				controls.Add(uCFrizer.cbStatus);
			}

			if (errors.Count > 0)
			{
				uCFrizer.ValidationError(errors, controls);
				return false;
			}
			else return true;
		}
	}
}
