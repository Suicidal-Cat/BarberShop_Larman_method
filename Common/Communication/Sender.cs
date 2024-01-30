using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common.Communication
{
	public class Sender
	{
		private NetworkStream stream;
		private BinaryFormatter formatter;
		private Socket socket;

		public Sender(Socket socket)
		{
			this.socket = socket;
			stream = new NetworkStream(socket);
			formatter = new BinaryFormatter();
		}

		public void Send(object argument)
		{
			try
			{
				formatter.Serialize(stream, argument);
			}catch(Exception ex)
			{
				MessageBox.Show("Greska u komunikaciji sa serverom");
				Environment.Exit(0);
			}
			
		}
	}
}
