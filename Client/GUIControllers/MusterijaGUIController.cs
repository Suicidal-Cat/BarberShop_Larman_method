using Client.UserControls.UCMusterija;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUIControllers
{
	internal class MusterijaGUIController
	{
		private UCDodajMusteriju uCDodajMusteriju;

		internal Control CreateUCMusterija()
		{
			uCDodajMusteriju=new UCDodajMusteriju();
			uCDodajMusteriju.btnBack.Click += (s, e) => MainCoordinator.Instance.ShowDefault();
			uCDodajMusteriju.btnSave.Click += SacuvajMusteriju;
			return uCDodajMusteriju;
		}

		private void SacuvajMusteriju(object sender, EventArgs e)
		{
			if (!ValidationMusterija()) return;
			Musterija musterija = new Musterija
			{
				Ime = uCDodajMusteriju.txtIme.Text.Trim(),
				Prezime = uCDodajMusteriju.txtPrezime.Text.Trim(),
				BrojTelefona = uCDodajMusteriju.txtBrTelfona.Text.Trim(),
				Email = uCDodajMusteriju.txtEmail.Text.Trim(),
				DatumRodjenja = uCDodajMusteriju.dateTimePicker1.Value,
			};
			Response res = Communication.Instance.DoadajMusteriju(musterija);
			MessageBox.Show(res.Message);
			uCDodajMusteriju.resetForm();
		}

		private bool ValidationMusterija()
		{
			List<string> errors = new List<string>();
			List<Control> controls = new List<Control>();

			if (string.IsNullOrEmpty(uCDodajMusteriju.txtIme.Text) || uCDodajMusteriju.txtIme.Text.Length < 2 || !uCDodajMusteriju.txtIme.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
			{
				errors.Add("Ime mora imati barem 2 slova i mora se sastojati samo od slova!");
				controls.Add(uCDodajMusteriju.txtIme);
			}

			if (string.IsNullOrEmpty(uCDodajMusteriju.txtPrezime.Text) || uCDodajMusteriju.txtIme.Text.Length < 2 || !uCDodajMusteriju.txtIme.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
			{
				errors.Add("Prezime mora imati barem 2 slova i mora se sastojati od slova!");
				controls.Add(uCDodajMusteriju.txtPrezime);
			}

			string patternBT = @"^\+(381|387|382|385)([1-9][0-9]{0,2})?([0-9]{6,7})$";
			string brTelefona = uCDodajMusteriju.txtBrTelfona.Text.Replace(" ", "");
			if (string.IsNullOrEmpty(uCDodajMusteriju.txtBrTelfona.Text) || !Regex.IsMatch(brTelefona, patternBT))
			{
				errors.Add("Molim vas unesite broj telefona u ispravnom formatu +38XXXXXXXXXX");
				controls.Add(uCDodajMusteriju.txtBrTelfona);
			}

			string patternEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
			Regex regex = new Regex(patternEmail);
			if (string.IsNullOrEmpty(uCDodajMusteriju.txtEmail.Text) || !Regex.IsMatch(uCDodajMusteriju.txtEmail.Text.Trim(), patternEmail))
			{
				errors.Add("Email ne moze biti prazan i mora biti u ispravnom formatu!");
				controls.Add(uCDodajMusteriju.txtEmail);
			}

			if (errors.Count > 0)
			{
				uCDodajMusteriju.ShowErrors(errors, controls);
				return false;
			}
			else return true;
		}
	}
}
