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
		FindService,
		UpdateService,
		DeleteService,
		CreateCustomer,
		CreateBarber,
		UpdateBarber,
		MakeCustomerReservation,
		UpdateCustomerReservation,
		AddBarberToReservation,
	}
}
