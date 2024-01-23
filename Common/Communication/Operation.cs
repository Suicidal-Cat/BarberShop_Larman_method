using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Communication
{
	public enum Operation
	{
		CreateService,
		GetAllServicesSearch,
		GetAllServicesByName,
		GetServiceById,
		FindService,
		UpdateService,
		DeleteService,
		CreateCustomer,
		CreateBarber,
		GetAllBarbersSearch,
		GetAllBarbersByName,
		GetBarberById,
		UpdateBarber,
		GetAllBarbers,//izbrisati sve vezano za ovo,communication, controller
		GetAllCustomers,
		MakeCustomerReservation,
		UpdateCustomerReservation,
		AddBarberToReservation,
	}
}
