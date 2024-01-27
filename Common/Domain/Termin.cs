using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
	[Serializable]
	public class Termin:IEntity
	{
        public int IdTermina { get; set; }
        public DateTime DatumTermina { get; set; }
        public string VremePocetka { get; set; }
		public int TrajanjeTerminaUMinutima { get; set; } = -1;
		public int UkupnaCena { get; set; } = -1;
        public Frizer Frizer { get; set; }
        public Musterija Musterija { get; set; }

		public string TableName => "Termin";
		public string DisplayValue => DatumTermina.Date.ToString()+" "+Frizer.DisplayValue;

		public string PrimaryKey => "IdTermina";

		public string GetByIDQuery()
		{
			return $"IdTermina={IdTermina}";
		}

		public string GetParametres()
		{
			return "@DatumTermina,@VremePocetka,@TrajanjeTerminaUMinutima,@UkupnaCena,@IdFrizera,@IdMusterije";
		}
		public void PrepareCommand(SqlCommand cmd)
		{
			cmd.Parameters.AddWithValue("@DatumTermina", DatumTermina);
			cmd.Parameters.AddWithValue("@VremePocetka", VremePocetka);
			cmd.Parameters.AddWithValue("@TrajanjeTerminaUMinutima", TrajanjeTerminaUMinutima);
			cmd.Parameters.AddWithValue("@UkupnaCena", UkupnaCena);
			if(Frizer!=null) cmd.Parameters.AddWithValue("@IdFrizera", Frizer.IdFrizera);
			else cmd.Parameters.AddWithValue("@IdFrizera",DBNull.Value);
			cmd.Parameters.AddWithValue("@IdMusterije", Musterija.IdMusterije);
		}

		public string UpdateQuery()
		{
			string ukupnaCena = UkupnaCena.ToString() == "-1" ? "" : $",UkupnaCena = '{UkupnaCena}'";
			string frizer = Frizer == null ? "" : $",IdFrizera = '{Frizer.IdFrizera}'";
			string trajanje = TrajanjeTerminaUMinutima.ToString() == "-1" ? "" : $",TrajanjeTerminaUMinutima = '{TrajanjeTerminaUMinutima}'";
			return $"DatumTermina='{DatumTermina}',VremePocetka='{VremePocetka}'"+frizer+ trajanje + ukupnaCena;
		}

		public List<IEntity> GetReaderList(SqlDataReader reader)
		{
			List<IEntity> entities = new List<IEntity>();
			while (reader.Read())
			{
				Termin termin = new Termin()
				{
					Musterija = new Musterija {
						IdMusterije = (int)reader["Musterija"],
						Ime = (string)reader["ImeMusterije"],
						Prezime = (string)reader["PrezimeMusterije"],
						DatumRodjenja = (DateTime)reader["DatumRodjenja"],
						BrojTelefona = (string)reader["TelefonMusterije"],
						Email = (string)reader["Email"],
					},
					IdTermina = (int)reader["IdTermina"],
					DatumTermina = (DateTime)reader["DatumTermina"],
					VremePocetka = (string)reader["VremePocetka"],
					TrajanjeTerminaUMinutima = (int)reader["TrajanjeTerminaUMinutima"],
					UkupnaCena = (int)reader["UkupnaCena"],
				};
				if (reader["Frizer"] != DBNull.Value)
				{
					Frizer f = new Frizer
					{
						IdFrizera = (int)reader["Frizer"],
						Ime = (string)reader["ImeFrizera"],
						Prezime = (string)reader["PrezimeFrizera"],
						Status = (Status)Enum.Parse(typeof(Status), (string)reader["Status"]),
					};
					termin.Frizer = f;
				}
				else termin.Frizer = null;
				entities.Add(termin);
			}
			return entities;
		}

		public IEntity GetReaderResult(SqlDataReader reader)
		{
			if(reader.Read())
			{
				Termin termin = new Termin()
				{
					Musterija = new Musterija
					{
						IdMusterije = (int)reader["Musterija"],
						Ime = (string)reader["ImeMusterije"],
						Prezime = (string)reader["PrezimeMusterije"],
						DatumRodjenja = (DateTime)reader["DatumRodjenja"],
						BrojTelefona = (string)reader["TelefonMusterije"],
						Email = (string)reader["Email"],
					},
					IdTermina = (int)reader["IdTermina"],
					DatumTermina = (DateTime)reader["DatumTermina"],
					VremePocetka = (string)reader["VremePocetka"],
					TrajanjeTerminaUMinutima = (int)reader["TrajanjeTerminaUMinutima"],
					UkupnaCena = (int)reader["UkupnaCena"],
				};
				if (reader["Frizer"] != DBNull.Value)
				{
					Frizer f = new Frizer
					{
						IdFrizera = (int)reader["Frizer"],
						Ime = (string)reader["ImeFrizera"],
						Prezime = (string)reader["PrezimeFrizera"],
						Status = (Status)Enum.Parse(typeof(Status), (string)reader["Status"]),
					};
					termin.Frizer = f;
				}
				else termin.Frizer = null;
				return termin;
			}
			return null;
		}

		public string GetSearchAttributes()
		{
			return "tr.IdTermina,tr.DatumTermina,tr.VremePocetka,tr.TrajanjeTerminaUMinutima,tr.UkupnaCena,tr.IdFrizera as Frizer,tr.IdMusterije as Musterija,mu.Ime as ImeMusterije,mu.Prezime as PrezimeMusterije,mu.DatumRodjenja,mu.BrojTelefona as TelefonMusterije,mu.Email,fr.Ime as ImeFrizera,fr.Prezime as PrezimeFrizera,fr.Pol,fr.BrojTelefona as TelefonFrizera,fr.Status,fr.DatumZaposlenja";
		}

		public List<IEntity> ReadAllSearch(SqlDataReader reader)
		{
			List<IEntity> entities = new List<IEntity>();
			while (reader.Read())
			{
				Termin termin = new Termin()
				{
					Musterija = new Musterija
					{
						IdMusterije = (int)reader["Musterija"],
						Ime = (string)reader["ImeMusterije"],
						Prezime = (string)reader["PrezimeMusterije"],
						DatumRodjenja = (DateTime)reader["DatumRodjenja"],
						BrojTelefona = (string)reader["TelefonMusterije"],
						Email = (string)reader["Email"],
					},
					IdTermina = (int)reader["IdTermina"],
					DatumTermina = (DateTime)reader["DatumTermina"],
					VremePocetka = (string)reader["VremePocetka"],
					TrajanjeTerminaUMinutima = (int)reader["TrajanjeTerminaUMinutima"],
					UkupnaCena = (int)reader["UkupnaCena"],
				};
				
				if (reader["Frizer"] != DBNull.Value)
				{
					Frizer f = new Frizer
					{
						IdFrizera = (int)reader["Frizer"],
						Ime = (string)reader["ImeFrizera"],
						Prezime = (string)reader["PrezimeFrizera"],
						Status = (Status)Enum.Parse(typeof(Status), (string)reader["Status"]),
					};
					termin.Frizer = f;
				}
				else termin.Frizer = null;
				entities.Add(termin);
			}
			return entities;
		}

		public string GetFilterQuery(string filter)
		{
			return $"tr.DatumTermina LIKE '{filter}'";
		}

		public string JoinQuery()
		{
			return "tr JOIN Musterija mu ON tr.IdMusterije=mu.IdMusterije left join Frizer fr on tr.IdFrizera=fr.IdFrizera";
		}
	}
}
