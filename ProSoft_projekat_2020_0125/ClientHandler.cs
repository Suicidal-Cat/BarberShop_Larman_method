using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProSoft_projekat_2020_0125
{
	public class ClientHandler
	{
		private Sender sender;
		private Receiver receiver;
		private Socket socket;

        public ClientHandler(Socket socket)
        {
            this.socket = socket;
			sender=new Sender(socket);
			receiver=new Receiver(socket);
        }

		public void HandleRequest()
		{
			try
			{
				while (true)
				{
					Request req = (Request)receiver.Receive();
					Response r = ProcessRequest(req);
					sender.Send(r);
				}
			}
			catch (IOException ex)
			{
				Debug.WriteLine(">>>>>>"+ ex.Message);
			}
			
		}

		private Response ProcessRequest(Request req)
		{
			Response res = new Response();
			try
			{
				switch (req.Operation)
				{
					case Operation.CreateService:
						{
							Controller.Instance.AddService((Usluga)req.Argument);
							res.Message = "Sistem je uspesno kreirao uslugu!";
						}
						break;
					case Operation.GetAllServicesSearch:
						{
							if(req.Argument!=null && (bool)req.Argument) res.Result = Controller.Instance.SearchAllServices(true);
							else res.Result = Controller.Instance.SearchAllServices();
						}
						break;
					case Operation.GetAllServicesByName:
						{
							res.Result = Controller.Instance.GetAllServicesFilter((string)req.Argument);
						}
						break;
					case Operation.GetServiceById:
						{
							res.Result = Controller.Instance.GetServiceById((Usluga)req.Argument);
						}
						break;
					case Operation.UpdateService:
						{
							Controller.Instance.UpdateService((Usluga)req.Argument);
							res.Message = "Sistem je uspesno izmenio uslugu!";
						}
						break;
					case Operation.DeleteService:
						{
							Controller.Instance.DeleteService((Usluga)req.Argument);
							res.Message = "Sistem je uspesno izbrisao uslugu!";
						}
						break;
					case Operation.CreateCustomer:
						{
							Controller.Instance.AddCustomer((Musterija)req.Argument);
							res.Message = "Sistem je uspesno nalog musterije!";
						}
						break;
					case Operation.CreateBarber:
						{
							Controller.Instance.AddBarber((Frizer)req.Argument);
							res.Message = "Sistem je uspesno kreirao nalog frizera!";
						}
						break;
					case Operation.GetAllBarbers:
						break;
					case Operation.GetAllBarbersSearch:
						{
							res.Result = Controller.Instance.SearchAllBarbers();
                        }
						break;
					case Operation.GetAllBarbersByName:
						{
							res.Result = Controller.Instance.GetAllBarbersFilter((string)req.Argument);
                        }
						break;
					case Operation.GetBarberById:
						{
						res.Result=Controller.Instance.GetBarberById((int)req.Argument);
						}
						break;
					case Operation.UpdateBarber:
						{
							Controller.Instance.UpdateBarber((Frizer)req.Argument);
							res.Message = "Sistem je uspesno izmenio frizera";
						}
						break;
					case Operation.GetAllCustomers:
						{
							res.Result = Controller.Instance.GetAllCustomers();
						}
						break;
					case Operation.MakeCustomerReservation:
						{
							Controller.Instance.MakeReservation((List<DetaljiTermina>)req.Argument);
							res.Message="Termin je rezervisan!";
						}
						break;
					case Operation.UpdateCustomerReservation:
						break;
					case Operation.AddBarberToReservation:
						break;
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(">>>>>>>> "+ex.Message);
				res.Message=ex.Message;
			}
			return res;
		}

	}
}
