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
		}

		private FRMMain frmMain;
		private FrizerGUIController frizerGUIController;

		internal void ShowFRMMain()
		{

			frmMain = new FRMMain();
			frmMain.AutoSize = true;
			frmMain.ShowDialog();
		}
		internal void ShowAddFrizerPanel()
		{
			frmMain.ChangePanel(frizerGUIController.CreateUCDodajFrizera());
		}
	}
}
