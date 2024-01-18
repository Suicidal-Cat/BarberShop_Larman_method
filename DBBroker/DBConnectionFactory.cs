using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
	internal class DBConnectionFactory
	{
		private static DBConnectionFactory instance;
		private SqlConnection connection;
		private DBConnectionFactory() {
			connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
		}
		internal static DBConnectionFactory Instance
		{
			get
			{
				if (instance == null) instance = new DBConnectionFactory();
				return instance;
			}
		}

		public SqlConnection getConnection()
		{
			return connection;
		}

	}
}
