using Common.Domain;
using ProSoft_projekat_2020_0125.SystemOperation;
using ProSoft_projekat_2020_0125.SystemOperation.SOFrizer;
using ProSoft_projekat_2020_0125.SystemOperation.SOUsluga;
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

		//barbers
		internal void AddBarber(Frizer f)
		{
			KreirajNalogFrizeraSO so=new KreirajNalogFrizeraSO(f);
			so.ExecuteTemplate();
		}
		internal List<Frizer> SearchAllBarbers()
		{
			UcitajListuFrizeraSO so=new UcitajListuFrizeraSO();
			so.ExecuteTemplate();
			return so.result.Cast<Frizer>().ToList();
		}
		internal List<Frizer> GetAllBarbersFilter(string filter)
		{
			NadjiFrizereSO so=new NadjiFrizereSO(filter);
			so.ExecuteTemplate();
			return so.result.Cast<Frizer>().ToList();
		}
		internal Frizer GetBarberById(int id) {
			UcitajFrizera so = new UcitajFrizera(id);
			so.ExecuteTemplate();
			return (Frizer)so.result;
		}
		internal void UpdateFrizer(Frizer f)
		{
			IzmeniFrizeraSO so = new IzmeniFrizeraSO(f);
			so.ExecuteTemplate();
		}
		//services
		internal void AddService(Usluga usluga)
		{
			KreirajUsluguSO so = new KreirajUsluguSO(usluga);
			so.ExecuteTemplate();
		}
		internal List<Usluga> SearchAllServices()
		{
			UcitajListuUslugaSO so = new UcitajListuUslugaSO();
			so.ExecuteTemplate();
			return so.result.Cast<Usluga>().ToList();
		}
	}
}
