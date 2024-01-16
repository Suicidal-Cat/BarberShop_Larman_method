using Client.GUIControllers;
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
			dodajFrizeraItem.Click += (s, e) => MainCoordinator.Instance.ShowAddFrizerPanel();
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
