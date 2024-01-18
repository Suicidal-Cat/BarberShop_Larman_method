﻿using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Client.UserControls.UCUsluga
{
	public partial class UCSingleUsluga : UserControl
	{
        public Usluga Usluga { get; set; }
        public UCSingleUsluga(UCMode mode,Usluga usluga=null)
		{
			InitializeComponent();
			prepareForm(mode);
			Usluga=usluga;
		}

		private void prepareForm(UCMode mode)
		{
			if (mode == UCMode.Show)
			{
				btnSave.Enabled = false;
			}
		}
		internal void resetForm()
		{
			txtCena.Text = string.Empty;
			txtNaziv.Text = string.Empty;
			txtTrajanje.Text = string.Empty;
			txtNaziv.BackColor = Color.White;
			txtCena.BackColor = Color.White;
			txtTrajanje.BackColor = Color.White;
		}
		

		internal void ShowErrors(List<string>errors,List<Control>controls)
		{
			txtNaziv.BackColor = Color.White;
			txtCena.BackColor = Color.White;
			txtTrajanje.BackColor = Color.White;

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