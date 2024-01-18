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
        public int TrajanjeTerminaUMinutima { get; set; }
        public int UkupnaCena { get; set; }
        public Frizer Frizer { get; set; }
        public Musterija Musterija { get; set; }

		public string TableName => "Termin";

		public string Values => $"'{DatumTermina.ToString("yyyy-MM-dd")}', '{VremePocetka}', '{TrajanjeTerminaUMinutima}', '{UkupnaCena}',"+Frizer==null?null:$"'{Frizer.IdFrizera}'"+ $",'{Musterija.IdMusterije}'";

		public string GetByIDQuery()
		{
			return $"IdFrizera={IdTermina}";
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
			cmd.Parameters.AddWithValue("@IdFrizera", Frizer.IdFrizera);
			cmd.Parameters.AddWithValue("@IdMusterije", Musterija.IdMusterije);
		}

		public string UpdateQuery()
		{
			return $"DatumTermina='{DatumTermina}',VremePocetka='{VremePocetka}',IdFrizera='{Frizer.IdFrizera}'";
		}

		public List<IEntity> GetReaderList(SqlDataReader reader)
		{
			throw new NotImplementedException();
		}

		public IEntity GetReaderResult(SqlDataReader reader)
		{
			throw new NotImplementedException();
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
