using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls.UCMusterija
{
	public partial class UCDodajMusteriju : UserControl
	{
		public UCDodajMusteriju()
		{
			InitializeComponent();
			prepareForm();
		}

		private void prepareForm()
		{
			dateTimePicker1.MaxDate = DateTime.Now;
			DateTime now = new DateTime(DateTime.Now.Year - 120, DateTime.Now.Month, DateTime.Now.Day);
			dateTimePicker1.MinDate = now;
			dateTimePicker1.Value = new DateTime(DateTime.Now.Year-20,1,1);
			txtBrTelfona.Text = "+38XXXXXXXXXX";
			txtBrTelfona.ForeColor = Color.DarkGray;
		}
		internal void resetForm()
		{
			txtIme.BackColor = Color.White;
			txtPrezime.BackColor = Color.White;
			txtBrTelfona.Text = "+38XXXXXXXXXX";
			txtBrTelfona.ForeColor = Color.DarkGray;
			txtEmail.BackColor = Color.White;

			txtIme.Text = string.Empty;
			txtBrTelfona.Text = string.Empty;
			txtEmail.Text = string.Empty;
			txtPrezime.Text	= string.Empty;
			dateTimePicker1.Value = new DateTime(DateTime.Now.Year - 20, 1, 1);

		}
		internal void ShowErrors(List<string> errors, List<Control> controls)
		{
			txtIme.BackColor = Color.White;
			txtPrezime.BackColor = Color.White;
			txtBrTelfona.BackColor = Color.White;
			txtEmail.BackColor=Color.White;

			string errorMessage = "";
			if (errors.Count() == 0) return;
			for (int i = 0; i < controls.Count(); i++)
			{
				errorMessage += errors[i] + "\n";
				controls[i].BackColor = Color.LightSalmon;
			}
			MessageBox.Show(errorMessage);
		}

		private void txtBrTelfona_Click(object sender, EventArgs e)
		{
			if (txtBrTelfona.ForeColor == Color.DarkGray)
			{
				txtBrTelfona.Text = "";
				txtBrTelfona.ForeColor = Color.Black;
			}
		}
	}
}
