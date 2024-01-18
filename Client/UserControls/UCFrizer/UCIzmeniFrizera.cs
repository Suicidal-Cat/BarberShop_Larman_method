using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls
{
	public partial class UCIzmeniFrizera : UserControl
	{
		public UCIzmeniFrizera()
		{
			InitializeComponent();
		}
		internal void prepareDgv(List<Frizer> frizeri)
		{
			dgvFrizer.Rows.Clear();
			if (frizeri != null && frizeri.Count>0)
			{
				foreach (Frizer f in frizeri)
				{
					dgvFrizer.Rows.Add(f.IdFrizera.ToString(), f.Ime, f.Prezime, f.Status.ToString());
				}
			}
			else MessageBox.Show("Sistem nije uspeo da nadje frizere po zadatoj vrednosti!");

		}
		internal void ShowMessage(string message)
		{
			MessageBox.Show(message);
		}
	}
}
