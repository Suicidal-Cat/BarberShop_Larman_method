﻿using Client.GUIControllers;
using Client.UserControls;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
	public partial class FRMMain : Form
	{
		public FRMMain(string uloga="Vlasnik")
		{
			InitializeComponent();
			dodajFrizeraItem.Click += (s, e) => MainCoordinator.Instance.ShowFrizerPanel(UCMode.Add);
			izmeniFrizeraItem.Click += (s, e) => MainCoordinator.Instance.ShowSearchFrizera();
			dodajUsluguItem.Click += (s, e) => MainCoordinator.Instance.ShowUslugaPanel(UCMode.Add);
			pretraziUslugeItem.Click += (s, e) => MainCoordinator.Instance.ShowSearchUsluge();
			dodajNalogMusterijeItem.Click += (s, e) => MainCoordinator.Instance.ShowDodajMusteriju();
			rezervisiTerminItem.Click += (s, e) => MainCoordinator.Instance.ShowTerminPanel();
			dodeliTerminFrizeruItem.Click += (s, e) => MainCoordinator.Instance.ShowTerminFrizerPanel();
			if (uloga == "Frizer")
			{
				FrizerMenuItem.Enabled = false;
				UslugaMenuItem.Enabled = false;
            }
		}
		public void ChangePanel(Control control)
		{
			pnlMain.Controls.Clear();
			pnlMain.Controls.Add(control);
			control.Dock = DockStyle.Fill;
			pnlMain.AutoSize = true;
			pnlMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		}
	}
}
