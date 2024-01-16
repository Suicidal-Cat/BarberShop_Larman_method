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
	}
}
