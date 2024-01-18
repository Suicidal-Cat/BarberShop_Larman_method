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
        public Status Status { get; set; }
        public DateTime DatumZaposlenja { get; set; }

        public string TableName => "Frizer";

		public string Values => $"'{Ime}', '{Prezime}', '{PolFrizera}', '{BrojTelefona}'";

		public string GetByIDQuery()
		{
			return $"IdFrizera={IdFrizera}";
		}

		public string GetParametres()
		{
			return "@Ime,@Prezime,@PolFrizera,@BrojTelefona,@Status,@DatumZaposlenja";
		}
		public string GetSearchAttributes()
		{
			return "IdFrizera,Ime,Prezime,Status";
		}
		public List<IEntity> ReadAllSearch(SqlDataReader reader)
		{
			List<IEntity> entities = new List<IEntity>();
			while (reader.Read())
			{
				Frizer frizer = new Frizer()
				{
					IdFrizera = (int)reader["IdFrizera"],
					Ime = (string)reader["Ime"],
					Prezime = (string)reader["Prezime"],
					Status = (Status)Enum.Parse(typeof(Status), (string)reader["Status"]),
				};
                entities.Add(frizer);
			}
			return entities;
		}

		public void PrepareCommand(SqlCommand cmd)
		{
			cmd.Parameters.AddWithValue("@Ime", Ime);
			cmd.Parameters.AddWithValue("@Prezime", Prezime);
			cmd.Parameters.AddWithValue("@PolFrizera", PolFrizera.ToString());
			cmd.Parameters.AddWithValue("@BrojTelefona", BrojTelefona);
			cmd.Parameters.AddWithValue("@Status", Status.ToString());
			cmd.Parameters.AddWithValue("@DatumZaposlenja", DatumZaposlenja.ToString("yyyy-MM-dd"));
		}

		public string UpdateQuery()
		{
			return $"Prezime='{Prezime}',BrojTelefona='{BrojTelefona}',Status='{Status}'";
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
					Status = (Status)Enum.Parse(typeof(Status), (string)reader["Status"]),
					DatumZaposlenja = (DateTime)reader["DatumZaposlenja"],
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
					PolFrizera = (Pol)Enum.Parse(typeof(Pol), (string)reader["Pol"]),
					BrojTelefona = (string)reader["BrojTelefona"],
					Status = (Status)Enum.Parse(typeof(Status), (string)reader["Status"]),
					DatumZaposlenja = (DateTime)reader["DatumZaposlenja"],
				};
				return frizer;
			}
			else return null;
		}

		public string GetFilterQuery(string filter)
		{
			return $"LOWER(Ime) LIKE CONCAT(LOWER('{filter}'),'%');";
		}
	}
}
