﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
    public class DBConnection
    {
        SqlConnection connection;
        SqlTransaction transaction;
        public DBConnection() {
			connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
		}
		public void OpenConnection()
		{
			connection?.Open();
		}

		public void CloseConnection()
		{
			connection?.Close();
		}

		public void BeginTransaction()
		{
			transaction = connection.BeginTransaction();
		}
		public void Commit()
		{
			transaction?.Commit();
		}
		public void Rollback()
		{
			transaction.Rollback();
		}
		public SqlCommand CreateCommand()
		{
			return new SqlCommand("", connection, transaction);
		}
	}
}
