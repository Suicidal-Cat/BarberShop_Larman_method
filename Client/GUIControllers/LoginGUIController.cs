using Client.Forms;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUIControllers
{
	internal class LoginGUIController
	{
		private static LoginGUIController instance;
		public static LoginGUIController Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new LoginGUIController();
				}
				return instance;
			}
		}
		private LoginGUIController()
		{
		}
		private FRMLogin frmLogin;
		internal void ShowFrmLogin()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			frmLogin = new FRMLogin();
			frmLogin.btnLogin.Click += (s, e) => Login();
			frmLogin.AutoSize = true;
			Application.Run(frmLogin);
		}

		internal void Login()
		{
				if (!ValidateLogin()) return;
			try
			{
				Communication.Instance.Connect();
				Korisnik korisnik = Communication.Instance.Login(frmLogin.txtUsername.Text, frmLogin.txtPassword.Text);
				if (korisnik == null)
				{
					MessageBox.Show("Ne postoji korisnik sa tim username i password!");
				}
				else
				{
					frmLogin.Hide();
					MainCoordinator.Instance.ShowFRMMain(korisnik.Uloga);
					frmLogin.Close();
					Communication.Instance.Close();
				}
			}
			catch (Exception ex) {
				MessageBox.Show("Server je ugasen!");
				return;
			}
			
		}

		private bool ValidateLogin()
		{
			frmLogin.txtUsername.BackColor=Color.White;
			frmLogin.txtPassword.BackColor = Color.White;

			string message = "";
			if(string.IsNullOrEmpty(frmLogin.txtUsername.Text)|| frmLogin.txtUsername.Text.Length<4) {
				message += "Username mora biti duzi od 4 karaktera!\n";
				frmLogin.txtUsername.BackColor = Color.LightCoral;
			}
			if (string.IsNullOrEmpty(frmLogin.txtPassword.Text) || frmLogin.txtPassword.Text.Length < 4)
			{
				message += "Password mora biti duzi od 4 karaktera!\n";
				frmLogin.txtPassword.BackColor = Color.LightCoral;
			}
			if (message != "")
			{
				MessageBox.Show(message);
				return false;
			}
			return true;
		}

	}
}
