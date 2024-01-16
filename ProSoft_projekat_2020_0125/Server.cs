using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;
using System.Diagnostics;

namespace ProSoft_projekat_2020_0125
{
	public class Server
	{
		Socket socket;
        public Server()
        {
			socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		}
		public void Start()
		{
			IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]), int.Parse(ConfigurationManager.AppSettings["port"]));

			socket.Bind(endPoint);
			socket.Listen(5);

			Thread thread = new Thread(AcceptClient);
			thread.IsBackground = true;
			thread.Start();

		}
		public void AcceptClient()
		{
			try
			{
				while (true)
				{
					Socket klijentskiSoket = socket.Accept();
					ClientHandler handler = new ClientHandler(klijentskiSoket);
					Thread klijentskaNit = new Thread(handler.HandleRequest);
					klijentskaNit.IsBackground = true;
					klijentskaNit.Start();
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}


		public void Stop()
		{
			socket?.Close();
		}
	}
}
