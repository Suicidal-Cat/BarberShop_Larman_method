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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Client.GUIControllers
{
	internal class FrizerGUIController
	{
		private UCDodajFrizera uCdodajFrizera;

		internal Control CreateUCDodajFrizera()
		{
			uCdodajFrizera = new UCDodajFrizera();
			uCdodajFrizera.btnDodajFrizera.Click += DodajFrizera;
			return uCdodajFrizera;
		}

		private void DodajFrizera(object sender, EventArgs e)
		{
			if (!ValidationDodajFrizera()) return;
			Frizer frizer = new Frizer()
			{
				Ime = uCdodajFrizera.txtIme.Text.Trim(),
				Prezime = uCdodajFrizera.txtPrezime.Text.Trim(),
				PolFrizera = (Pol)uCdodajFrizera.cbPol.SelectedItem,
				BrojTelefona= uCdodajFrizera.txtBrTelfona.Text.Trim(),
			};
			Response response = Communication.Instance.DodajFrizera(frizer);
			uCdodajFrizera.ShowMessage(response.Message);
			
		}
		private bool ValidationDodajFrizera()
		{
			List<string> errors = new List<string>();
			List<Control> controls = new List<Control>();
			if (string.IsNullOrEmpty(uCdodajFrizera.txtIme.Text) || uCdodajFrizera.txtIme.Text.Length < 2 || !uCdodajFrizera.txtIme.Text.All(char.IsLetter))
			{
				errors.Add("Ime mora imati barem 2 slova i mora se sastojati od slova!");
				controls.Add(uCdodajFrizera.txtIme);
			}
			if (string.IsNullOrEmpty(uCdodajFrizera.txtPrezime.Text) || uCdodajFrizera.txtIme.Text.Length < 2 || !uCdodajFrizera.txtIme.Text.All(char.IsLetter))
			{
				errors.Add("Prezime mora imati barem 2 slova i mora se sastojati od slova!");
				controls.Add(uCdodajFrizera.txtPrezime);
			}
			if (uCdodajFrizera.cbPol.SelectedIndex < 0)
			{
				errors.Add("Molim vas izaberite pol frizera");
				controls.Add(uCdodajFrizera.cbPol);
			}
			string pattern = @"^\+(381|387|382|385)([1-9][0-9]{0,2})?([0-9]{6,7})$";
			string brTelefona = uCdodajFrizera.txtBrTelfona.Text.Replace(" ","");
            if (string.IsNullOrEmpty(uCdodajFrizera.txtBrTelfona.Text) || !Regex.IsMatch(brTelefona, pattern))
			{
				errors.Add("Molim vas unesite broj telefona u ispravnom formatu +38XXXXXXXXXX");
				controls.Add(uCdodajFrizera.txtBrTelfona);
			}
			if(errors.Count > 0)
			{
				uCdodajFrizera.ValidationError(errors, controls);
				return false;
			}
			else return true;
		}
	}
}
