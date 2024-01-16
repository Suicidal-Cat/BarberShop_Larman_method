using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls
{
	public partial class UCDodajFrizera : UserControl
	{
		public UCDodajFrizera()
		{
			InitializeComponent();
			PrepareForm();
		}
		
		internal void PrepareForm()
		{
			cbPol.DataSource = Enum.GetValues(typeof(Pol));
			cbPol.SelectedIndex = -1;
			txtBrTelfona.Text = "+38XXXXXXXXXX";
			txtBrTelfona.ForeColor = Color.DarkGray;
		}
		internal void ShowMessage(string message)
		{
			MessageBox.Show(message);
		}
		internal void ValidationError(List<string> errors, List<Control> controls)
		{
			txtIme.BackColor = Color.White;
			txtPrezime.BackColor = Color.White;
			cbPol.BackColor = Color.White;
			txtBrTelfona.BackColor = Color.White;

			string errorMessage = "";
			if (errors.Count() == 0) return;
			for (int i = 0; i < controls.Count(); i++)
			{
				errorMessage += errors[i] + "\n";
				controls[i].BackColor = Color.LightSalmon;
			}

			MessageBox.Show(errorMessage);

		}

		private void txtBrTelfona_MouseClick(object sender, MouseEventArgs e)
		{
			if (txtBrTelfona.ForeColor == Color.DarkGray)
			{
				txtBrTelfona.Text = "";
				txtBrTelfona.ForeColor = Color.Black;
			}
		}
	}
}
