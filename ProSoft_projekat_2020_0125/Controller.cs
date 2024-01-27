using Common.Domain;
using ProSoft_projekat_2020_0125.SystemOperation;
using ProSoft_projekat_2020_0125.SystemOperation.SOFrizer;
using ProSoft_projekat_2020_0125.SystemOperation.SOMusterija;
using ProSoft_projekat_2020_0125.SystemOperation.SOTermin;
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
			UcitajFrizeraSO so = new UcitajFrizeraSO(id);
			so.ExecuteTemplate();
			return (Frizer)so.result;
		}
		internal void UpdateBarber(Frizer f)
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
		internal List<Usluga> SearchAllServices(bool all = false)
		{
			UcitajListuUslugaSO so = new UcitajListuUslugaSO(all);
			so.ExecuteTemplate();
			return so.result.Cast<Usluga>().ToList();
		}
		internal List<Usluga> GetAllServicesFilter(string filter)
		{
			NadjiUslugeSO so = new NadjiUslugeSO(filter);
			so.ExecuteTemplate();
			return so.result.Cast<Usluga>().ToList();
		}
		internal Usluga GetServiceById(Usluga u)
		{
			UcitajUsluguSO so = new UcitajUsluguSO(u);
			so.ExecuteTemplate();
			return (Usluga)so.result;
		}
		internal void UpdateService(Usluga u)
		{
			IzmeniUsluguSO so = new IzmeniUsluguSO(u);
			so.ExecuteTemplate();
		}
		internal void DeleteService(Usluga u)
		{
			ObrisiUsluguSO so = new ObrisiUsluguSO(u);
			so.ExecuteTemplate();
		}
		//customers
		internal void AddCustomer(Musterija musterija)
		{
			KreirajNalogMusterijeSO so = new KreirajNalogMusterijeSO(musterija);
			so.ExecuteTemplate();
		}
		internal List<Musterija> GetAllCustomers()
		{
			UcitajListuMusterijaSO so = new UcitajListuMusterijaSO();
			so.ExecuteTemplate();
			return so.Result.Cast<Musterija>().ToList();
		}
		//reservations
		internal void MakeReservation(List<DetaljiTermina>detaljiTermina)
		{
			KreirajTerminZaMusterijuSO so = new KreirajTerminZaMusterijuSO(detaljiTermina);
			so.ExecuteTemplate();
		}
		internal List<Termin> GetAllReservationsFilter(string filter)
		{
			NadjiTermineSO so = new NadjiTermineSO(filter);
			so.ExecuteTemplate();
			return so.result.Cast<Termin>().ToList();
		}
		internal void UpdateReservationBarber(Termin t)
		{
			DodeliFrizeraTerminuSO so = new DodeliFrizeraTerminuSO(t);
			so.ExecuteTemplate();
		}
		internal List<DetaljiTermina> GetDetalisByReservation(Termin t)
		{
			UcitajTerminSO so=new UcitajTerminSO(t);
			so.ExecuteTemplate();
			return so.result.Cast<DetaljiTermina>().ToList();
		}
		internal void ChangeReservationDetails(List<DetaljiTermina> detaljiTermina)
		{
			IzmeniTerminSO so = new IzmeniTerminSO(detaljiTermina);
			so.ExecuteTemplate();
		}
	}
}
