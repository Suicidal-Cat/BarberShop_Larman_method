using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProSoft_projekat_2020_0125
{
	public partial class FRMServer : Form
	{
		Server server;
		public FRMServer()
		{
			InitializeComponent();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			server = new Server();
			server.Start();

			btnStart.Enabled = false;
			btnStop.Enabled = true;
			lblServerStatus.Text = "Server is running...";
			lblServerStatus.ForeColor = Color.SpringGreen;			
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			btnStart.Enabled = true;
			btnStop.Enabled = false;
			lblServerStatus.Text = "Server is down";
			lblServerStatus.ForeColor = Color.Crimson;
			server.Stop();
		}

		private void FRMServer_FormClosed(object sender, FormClosedEventArgs e)
		{
			Environment.Exit(0);
		}
	}
}
