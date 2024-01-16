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
						break;
					case Operation.FindService:
						break;
					case Operation.UpdateService:
						break;
					case Operation.DeleteService:
						break;
					case Operation.CreateCustomer:
						break;
					case Operation.CreateBarber:
						{
							Controller.Instance.AddBarber((Frizer)req.Argument);
							res.Message = "Uspesno kreiran nalog frizera!";
						}
						break;
					case Operation.UpdateBarber:
						break;
					case Operation.MakeCustomerReservation:
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
