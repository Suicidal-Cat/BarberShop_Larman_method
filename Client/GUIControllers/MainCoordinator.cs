using Client.UserControls;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
			musterijaGUIController=new MusterijaGUIController();
			terminGUIController=new TerminGUIController();
		}

		private FRMMain frmMain;
		private FrizerGUIController frizerGUIController;
		private UslugaGUIController uslugaGUIController;
		private MusterijaGUIController musterijaGUIController;
		private TerminGUIController terminGUIController;

		internal void ShowFRMMain(string uloga="Vlasnik")
		{
			frmMain = new FRMMain(uloga);
			frmMain.AutoSize = true;
			ShowDefault();
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
			UCDefaultMain main = new UCDefaultMain();
			main.btnRezervisi.Click += (s, e) => ShowTerminPanel();
			frmMain.ChangePanel(main);
		}
		internal void ShowUslugaPanel(UCMode mode, Usluga usluga = null)
		{
			frmMain.ChangePanel(uslugaGUIController.CreateUCUsluga(mode,usluga));
		}
		internal void ShowSearchUsluge()
		{
			frmMain.ChangePanel(uslugaGUIController.CreateUCSearchUsluga());
		}
		internal void ShowDodajMusteriju()
		{
			frmMain.ChangePanel(musterijaGUIController.CreateUCMusterija());
		}
		internal void ShowTerminPanel(UCMode mode = UCMode.Add, List<DetaljiTermina> dtTer = null)
		{
			frmMain.ChangePanel(terminGUIController.CreateUCTermin(mode,dtTer));
		}
		internal void ShowTerminFrizerPanel()
		{
			frmMain.ChangePanel(terminGUIController.CreateUCDodajFrizeraTerminu());
		}
	}
}
