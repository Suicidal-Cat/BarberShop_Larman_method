using Client.GUIControllers;
using Client.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
	public partial class FRMMain : Form
	{
		public FRMMain()
		{
			InitializeComponent();
			dodajFrizeraItem.Click += (s, e) => MainCoordinator.Instance.ShowFrizerPanel(UCMode.Add);
			izmeniFrizeraItem.Click += (s, e) => MainCoordinator.Instance.ShowSearchFrizera();
			dodajUsluguItem.Click += (s, e) => MainCoordinator.Instance.ShowUslugaPanel(UCMode.Add);
			pretraziUslugeItem.Click += (s, e) => MainCoordinator.Instance.ShowSearchUsluge();
			dodajNalogMusterijeItem.Click += (s, e) => MainCoordinator.Instance.ShowDodajMusteriju();
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
