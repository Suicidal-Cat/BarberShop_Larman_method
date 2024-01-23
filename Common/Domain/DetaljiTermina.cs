using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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

		public string Values => $"'{Termin.IdTermina}', '{Usluga.IdUsluge}', '{Napomena}'";

		public string DisplayValue => throw new NotImplementedException();

		public string PrimaryKey => throw new NotImplementedException();

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
