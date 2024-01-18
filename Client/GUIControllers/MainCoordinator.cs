using Client.UserControls;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.GUIControllers
{
	internal class MainCoordinator
	{
		private static MainCoordinator instance;
		public static MainCoordinator Instance { get
			{
				if(instance == null)instance = new MainCoordinator();
				return instance;
			} 
		}
		private MainCoordinator() {
			frizerGUIController=new FrizerGUIController();
			uslugaGUIController=new UslugaGUIController();
		}

		private FRMMain frmMain;
		private FrizerGUIController frizerGUIController;
		private UslugaGUIController uslugaGUIController;

		internal void ShowFRMMain()
		{

			frmMain = new FRMMain();
			frmMain.AutoSize = true;
			frmMain.ShowDialog();
		}
		internal void ShowFrizerPanel(UCMode mode,Frizer frizer=null)
		{
			frmMain.ChangePanel(frizerGUIController.CreateUCFrizer(mode,frizer));
		}
		internal void ShowSearchFrizera()
		{
			frmMain.ChangePanel(frizerGUIController.CreateUCIzmeniFrizera());
		}
		internal void ShowDefault()
		{
			frmMain.pnlMain.Controls.Clear();
		}
		internal void ShowUslugaPanel(UCMode mode, Usluga usluga = null)
		{
			frmMain.ChangePanel(uslugaGUIController.CreateUCUsluga(mode,usluga));
		}
		internal void ShowSearchUsluge()
		{
			frmMain.ChangePanel(uslugaGUIController.CreateUCSearchUsluga());
		}
	}
}
