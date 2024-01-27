using Client.UserControls.UCMusterija;
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
	internal class MusterijaGUIController
	{
		private UCDodajMusteriju uCDodajMusteriju;

		internal Control CreateUCMusterija()
		{
			uCDodajMusteriju=new UCDodajMusteriju();
			prepareFormMusterija();
			uCDodajMusteriju.txtBrTelfona.MouseClick += PromeniTxtTelefon;
			uCDodajMusteriju.btnBack.Click += (s, e) => MainCoordinator.Instance.ShowDefault();
			uCDodajMusteriju.btnSave.Click += SacuvajMusteriju;
			return uCDodajMusteriju;
		}

		private void PromeniTxtTelefon(object sender, MouseEventArgs e)
		{
			if (uCDodajMusteriju.txtBrTelfona.ForeColor == Color.DarkGray)
			{
				uCDodajMusteriju.txtBrTelfona.Text = "";
				uCDodajMusteriju.txtBrTelfona.ForeColor = Color.Black;
			}
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
			resetForm();
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
				ShowErrors(errors, controls);
				return false;
			}
			else return true;
		}
		private void prepareFormMusterija()
		{
			uCDodajMusteriju.dateTimePicker1.MaxDate = DateTime.Now;
			DateTime now = new DateTime(DateTime.Now.Year - 120, DateTime.Now.Month, DateTime.Now.Day);
			uCDodajMusteriju.dateTimePicker1.MinDate = now;
			uCDodajMusteriju.dateTimePicker1.Value = new DateTime(DateTime.Now.Year - 20, 1, 1);
			uCDodajMusteriju.txtBrTelfona.Text = "+38XXXXXXXXXX";
			uCDodajMusteriju.txtBrTelfona.ForeColor = Color.DarkGray;
		}
		internal void resetForm()
		{
			uCDodajMusteriju.txtIme.BackColor = Color.White;
			uCDodajMusteriju.txtPrezime.BackColor = Color.White;
			uCDodajMusteriju.txtBrTelfona.Text = "+38XXXXXXXXXX";
			uCDodajMusteriju.txtBrTelfona.ForeColor = Color.DarkGray;
			uCDodajMusteriju.txtEmail.BackColor = Color.White;

			uCDodajMusteriju.txtIme.Text = string.Empty;
			uCDodajMusteriju.txtBrTelfona.Text = string.Empty;
			uCDodajMusteriju.txtEmail.Text = string.Empty;
			uCDodajMusteriju.txtPrezime.Text = string.Empty;
			uCDodajMusteriju.dateTimePicker1.Value = new DateTime(DateTime.Now.Year - 20, 1, 1);
		}
		internal void ShowErrors(List<string> errors, List<Control> controls)
		{
			uCDodajMusteriju.txtIme.BackColor = Color.White;
			uCDodajMusteriju.txtPrezime.BackColor = Color.White;
			uCDodajMusteriju.txtBrTelfona.BackColor = Color.White;
			uCDodajMusteriju.txtEmail.BackColor=Color.White;

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
}
