﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Communication
{
	public enum Operation
	{
		Login,
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
		GetAllReservationsSearch,
		MakeCustomerReservation,
		GetDetailsByReservation,
		UpdateCustomerReservation,
		AddBarberToReservation,
	}
}
