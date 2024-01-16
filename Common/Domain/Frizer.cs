using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
	[Serializable]
	public class Frizer:IEntity
	{
        public int IdFrizera { get; set; }
        public string Ime { get; set; }
		public string Prezime { get; set; }
        public Pol PolFrizera { get; set; }
        public string BrojTelefona { get; set; }

		public string TableName => "Frizer";

		public string Values => $"'{Ime}', '{Prezime}', '{PolFrizera}', '{BrojTelefona}'";

		public string GetByIDQuery()
		{
			return $"IdFrizera={IdFrizera}";
		}

		public string GetParametres()
		{
			return "@Ime,@Prezime,@PolFrizera,@BrojTelefona";
		}
		public void PrepareCommand(SqlCommand cmd)
		{
			cmd.Parameters.AddWithValue("@Ime", Ime);
			cmd.Parameters.AddWithValue("@Prezime", Prezime);
			cmd.Parameters.AddWithValue("@PolFrizera", PolFrizera.ToString());
			cmd.Parameters.AddWithValue("@BrojTelefona", BrojTelefona);
		}

		public string UpdateQuery()
		{
			return $"Prezime='{Prezime}',BrojTelefona='{BrojTelefona}'";
		}

		public List<IEntity> GetReaderList(SqlDataReader reader)
		{
			List<IEntity>entities = new List<IEntity>();
			while (reader.Read())
			{
				Frizer frizer = new Frizer()
				{
					IdFrizera = (int)reader["IdFrizera"],
					Ime = (string)reader["Ime"],
					Prezime = (string)reader["Prezime"],
					PolFrizera =(Pol)Enum.Parse(typeof(Pol),(string) reader["PolFrizera"]),
					BrojTelefona = (string)reader["BrojTelefona"],
				};
				entities.Add(frizer);
			}
			return entities;
		}

		public IEntity GetReaderResult(SqlDataReader reader)
		{
			if (reader.Read())
			{
				Frizer frizer = new Frizer()
				{
					IdFrizera = (int)reader["IdFrizera"],
					Ime = (string)reader["Ime"],
					Prezime = (string)reader["Prezime"],
					PolFrizera = (Pol)Enum.Parse(typeof(Pol), (string)reader["PolFrizera"]),
					BrojTelefona = (string)reader["BrojTelefona"],
				};
				return frizer;
			}
			else return null;
		}
	}
}
