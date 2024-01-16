using Common.Domain;
using ProSoft_projekat_2020_0125.SystemOperation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSoft_projekat_2020_0125
{
	public class Controller
	{
		private static Controller instance;
		public static Controller Instance
		{
			get
			{
				if(instance == null)instance = new Controller();
				return instance;
			}
		}
		private Controller() { }

		internal void AddBarber(Frizer f)
		{
			KreirajNalogFrizeraSO so=new KreirajNalogFrizeraSO(f);
			so.ExecuteTemplate();
		}

	}
}
