using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
	[Serializable]
	public class DetaljiTermina:IEntity
	{
		public Termin Termin { get; set; }
		public Usluga Usluga { get; set; }
        public string Napomena { get; set; }

		public string TableName => "DetaljiTermina";
		public string DisplayValue => "";

		public string PrimaryKey => "IdTermina,IdUsluga";
        public string Status { get; set; }

        public string GetByIDQuery()
		{
			return $"IdTermina={Termin.IdTermina} AND IdUsluge={Usluga.IdUsluge}";
		}

		public string GetParametres()
		{
			return "@IdTermina,@IdUsluge,@Napomena";
		}
		public void PrepareCommand(SqlCommand cmd)
		{
			cmd.Parameters.AddWithValue("@IdTermina", Termin.IdTermina);
			cmd.Parameters.AddWithValue("@IdUsluge", Usluga.IdUsluge);
			cmd.Parameters.AddWithValue("@Napomena", Napomena);
		}

		public string UpdateQuery()
		{
			return $"Napomena='{Napomena}'";
		}
		public string GetSearchAttributes()
		{
			return "dt.IdTermina,dt.IdUsluge,dt.Napomena,tr.DatumTermina,tr.VremePocetka,tr.TrajanjeTerminaUMinutima,tr.UkupnaCena,tr.IdMusterije,mu.Ime,mu.Prezime,u.IdUsluge,u.NazivUsluge,u.CenaUsluge,u.TrajanjeUslugeUMinutima";
		}

		public string JoinQuery()
		{
			return $"dt join termin tr on dt.IdTermina=tr.IdTermina join Musterija mu on tr.IdMusterije=mu.IdMusterije join Usluga u on u.IdUsluge=dt.IdUsluge WHERE dt.IdTermina={Termin.IdTermina}";
		}

		public List<IEntity> ReadAllSearch(SqlDataReader reader)
		{
			List<IEntity> entities = new List<IEntity>();
			while (reader.Read())
			{
				DetaljiTermina dttermina = new DetaljiTermina()
				{
					Termin = new Termin
					{
						IdTermina = (int)reader["IdTermina"],
						DatumTermina = (DateTime)reader["DatumTermina"],
						VremePocetka = (string)reader["VremePocetka"],
						TrajanjeTerminaUMinutima = (int)reader["TrajanjeTerminaUMinutima"],
						UkupnaCena = (int)reader["UkupnaCena"],
						Musterija = new Musterija {
							IdMusterije = (int)reader["IdMusterije"],
						}
					},
					Usluga = new Usluga
					{
						IdUsluge = (int)reader["IdUsluge"],
						NazivUsluge = (string)reader["NazivUsluge"],
						CenaUsluge = (int)reader["CenaUsluge"],
						TrajanjeUslugeUMinutima = (int)reader["TrajanjeUslugeUMinutima"],
					},
					Napomena = (string)reader["Napomena"]
				};
				entities.Add(dttermina);
			}
			return entities;
		}

		public string GetFilterQuery(string filter)
		{
			throw new NotImplementedException();
		}

		public List<IEntity> GetReaderList(SqlDataReader reader)
		{
			throw new NotImplementedException();
		}

		public IEntity GetReaderResult(SqlDataReader reader)
		{
			throw new NotImplementedException();
		}
	}
}
