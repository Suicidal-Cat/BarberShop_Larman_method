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
	public partial class UCSingleFrizer : UserControl
	{
        public Frizer Frizer { get; set; }
        public UCSingleFrizer(UCMode mode,Frizer frizer=null)
		{
			InitializeComponent();
			PrepareForm(mode,frizer);
			Frizer= frizer;
		}
		
		internal void PrepareForm(UCMode mode,Frizer frizer=null)
		{
			cbPol.DataSource = Enum.GetValues(typeof(Pol));
			cbStatus.DataSource = Enum.GetValues(typeof(Status));
			txtDatumZaposlenja.Enabled = false;
			if (mode == UCMode.Add)
			{			
				cbPol.SelectedIndex = -1;
				txtBrTelfona.Text = "+38XXXXXXXXXX";
				txtBrTelfona.ForeColor = Color.DarkGray;
				cbStatus.SelectedIndex = (int)Status.Aktivan;
				txtDatumZaposlenja.Text = DateTime.Now.ToString("yyyy-MM-dd");
				cbStatus.Enabled = false;
			}
			else if(mode == UCMode.Update)
			{
				txtNaslov.Text = "Izmeni frizera";
				txtIme.Text = frizer.Ime;
				txtPrezime.Text = frizer.Prezime;
				txtBrTelfona.Text = frizer.BrojTelefona;
				cbPol.SelectedIndex = (int)frizer.PolFrizera;
				cbStatus.SelectedIndex = (int)frizer.Status;
				txtDatumZaposlenja.Text = frizer.DatumZaposlenja.ToString("yyyy-MM-dd");

				txtBrTelfona.ForeColor = Color.Black;
				txtIme.Enabled = false;
				cbPol.Enabled = false;

			}
			
		}
		internal void ResetForm()
		{
			txtIme.BackColor = txtPrezime.BackColor = cbPol.BackColor = Color.White;
			cbStatus.BackColor = Color.White;
			txtIme.Text = txtPrezime.Text = "";
			txtBrTelfona.Text = "+38XXXXXXXXXX";
			txtBrTelfona.ForeColor = Color.DarkGray;
			cbPol.SelectedIndex = -1;
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
