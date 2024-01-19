using Common.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Common.Domain;

namespace Client
{
	public class Communication
	{
		private static Communication _instance;
		public static Communication Instance
		{
			get
			{
				if (_instance == null) _instance = new Communication();
				return _instance;
			}
		}
		private Communication(){}

		Socket socket;
		Sender sender;
		Receiver receiver;

		public void Connect()
		{
			if(socket == null || !socket.Connected)
			{
				socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				socket.Connect(ConfigurationManager.AppSettings["ip"], int.Parse(ConfigurationManager.AppSettings["port"]));
				sender = new Sender(socket);
				receiver = new Receiver(socket);
			}
		
		}

		public Response DodajFrizera(Frizer frizer)
		{
			Request request = new Request(Operation.CreateBarber,frizer);
			sender.Send(request);
			return (Response)receiver.Receive();
		}
		public List<Frizer> GetAllBarbers()
		{
			Request request = new Request(Operation.GetAllBarbers, null);
			sender.Send(request);
			return (List<Frizer>)((Response)receiver.Receive()).Result;
		}
		public List<Frizer> PretraziSveFrizere()
		{
			Request request = new Request(Operation.GetAllBarbersSearch, null);
			sender.Send(request);
			return (List<Frizer>)((Response)receiver.Receive()).Result;
		}

		internal List<Frizer> PretraziPoImenuFrizere(string filter)
		{
			Request request = new Request(Operation.GetAllBarbersByName, filter);
			sender.Send(request);
            return (List<Frizer>)((Response)receiver.Receive()).Result;
		}
		internal Frizer NadjiFrizeraPoId(int id)
		{
			Request request = new Request(Operation.GetBarberById, id);
			sender.Send(request);
			return (Frizer)((Response)receiver.Receive()).Result;
		}
		internal Response IzmeniFrizera(Frizer frizer)
		{
			Request request = new Request(Operation.UpdateBarber,frizer);
			sender.Send(request);
			return (Response)receiver.Receive();
		}

		public Response DodajUslugu(Usluga frizer)
		{
			Request request = new Request(Operation.CreateService, frizer);
			sender.Send(request);
			return (Response)receiver.Receive();
		}

		internal List<Usluga> PretraziSveUsluge()
		{
			Request request = new Request(Operation.GetAllServicesSearch, null);
			sender.Send(request);
			return (List<Usluga>)((Response)receiver.Receive()).Result;
		}
		internal List<Usluga> PretraziPoImenuUsluge(string filter)
		{
			Request request = new Request(Operation.GetAllServicesByName, filter);
			sender.Send(request);
			return (List<Usluga>)((Response)receiver.Receive()).Result;
		}
		internal Usluga NadjiUsluguPoId(Usluga u)
		{
			Request request = new Request(Operation.GetServiceById, u);
			sender.Send(request);
			return (Usluga)((Response)receiver.Receive()).Result;
		}
		internal Response IzmeniUslugu(Usluga usluga)
		{
			Request request = new Request(Operation.UpdateService, usluga);
			sender.Send(request);
			return (Response)receiver.Receive();
		}
		internal Response IzbrisiUslugu(Usluga usluga)
		{
			Request request = new Request(Operation.DeleteService, usluga);
			sender.Send(request);
			return (Response)receiver.Receive();
		}
	}
}
