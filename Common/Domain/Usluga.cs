using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
	[Serializable]
	public class Usluga:IEntity
	{
        public int IdUsluge { get; set; }
        public string NazivUsluge { get; set; }
        public int CenaUsluge { get; set; }
        public int TrajanjeUslugeUMinutima { get; set; }

		public string TableName => "Usluga";

		public string Values => $"'{NazivUsluge}', '{CenaUsluge}', '{TrajanjeUslugeUMinutima}'";

		public string GetByIDQuery()
		{
			return $"IdFrizera={IdUsluge}";
		}

		public string GetParametres()
		{
			return "@NazivUsluge,@CenaUsluge,@TrajanjeUslugeUMinutima";
		}
		public void PrepareCommand(SqlCommand cmd)
		{
			cmd.Parameters.AddWithValue("@NazivUsluge", NazivUsluge);
			cmd.Parameters.AddWithValue("@CenaUsluge", CenaUsluge);
			cmd.Parameters.AddWithValue("@TrajanjeUslugeUMinutima", TrajanjeUslugeUMinutima);
		}

		public string UpdateQuery()
		{
			return $"CenaUsluge='{CenaUsluge}',TrajanjeUslugeUMinutima='{TrajanjeUslugeUMinutima}'";
		}

		public List<IEntity> GetReaderList(SqlDataReader reader)
		{
			List<IEntity> entities = new List<IEntity>();
			while (reader.Read())
			{
				Usluga usluga = new Usluga()
				{
					IdUsluge = (int)reader["IdUsluge"],
					NazivUsluge = (string)reader["NazivUsluge"],
					CenaUsluge = (int)reader["CenaUsluge"],
					TrajanjeUslugeUMinutima = (int)reader["TrajanjeUslugeUMinutima"],
				};
				entities.Add(usluga);
			}
			return entities;
		}

		public IEntity GetReaderResult(SqlDataReader reader)
		{
			if(reader.Read())
			{
				return new Usluga()
				{
					IdUsluge = (int)reader["IdUsluge"],
					NazivUsluge = (string)reader["NazivUsluge"],
					CenaUsluge = (int)reader["CenaUsluge"],
					TrajanjeUslugeUMinutima = (int)reader["TrajanjeUslugeUMinutima"],
				};
			}
			else return null;
		}

	}
}
