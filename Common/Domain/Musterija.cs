﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
	[Serializable]
	public class Musterija:IEntity
	{
        public int IdMusterije { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }

		public string TableName => "Musterija";

		public string Values => $"'{Ime}', '{Prezime}', '{DatumRodjenja.ToString("yyyy-MM-dd")}', '{BrojTelefona}','{Email}'";

		public string GetByIDQuery()
		{
			return $"IdFrizera={IdMusterije}";
		}

		public string GetParametres()
		{
			return "@Ime,@Prezime,@DatumRodjenja,@BrojTelefona,@Email";
		}
		public void PrepareCommand(SqlCommand cmd)
		{
			cmd.Parameters.AddWithValue("@Ime", Ime);
			cmd.Parameters.AddWithValue("@Prezime", Prezime);
			cmd.Parameters.AddWithValue("@DatumRodjenja", DatumRodjenja.ToString("yyyy-MM-dd"));
			cmd.Parameters.AddWithValue("@BrojTelefona", BrojTelefona);
			cmd.Parameters.AddWithValue("@Email", Email);
		}

		public string UpdateQuery()
		{
			return $"Prezime='{Prezime}',BrojTelefona='{BrojTelefona}',Email='{Email}'";
		}

		public List<IEntity> GetReaderList(SqlDataReader reader)
		{
			List<IEntity>entities = new List<IEntity>();
			while (reader.Read())
			{
				Musterija musterija = new Musterija() {
					IdMusterije = (int)reader["IdFrizera"],
					Ime = (string)reader["Ime"],
					Prezime = (string)reader["Prezime"],
					DatumRodjenja = (DateTime)reader["DatumRodjenja"],
					BrojTelefona = (string)reader["BrojTelefona"],
					Email = (string)reader["Email"],
				};
				entities.Add(musterija);
			}
			return entities;
		}

		public IEntity GetReaderResult(SqlDataReader reader)
		{
			if(reader.Read())
			{
				Musterija musterija = new Musterija()
				{
					IdMusterije = (int)reader["IdFrizera"],
					Ime = (string)reader["Ime"],
					Prezime = (string)reader["Prezime"],
					DatumRodjenja = (DateTime)reader["DatumRodjenja"],
					BrojTelefona = (string)reader["BrojTelefona"],
					Email = (string)reader["Email"],
				};
				return musterija;
			}
			else return null;
		}

		public string GetSearchAttributes()
		{
			throw new NotImplementedException();
		}

		public List<IEntity> ReadAllSearch(SqlDataReader reader)
		{
			throw new NotImplementedException();
		}

		public string GetFilterQuery(string filter)
		{
			throw new NotImplementedException();
		}
	}
}
