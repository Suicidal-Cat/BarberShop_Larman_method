using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
	[Serializable]
	public class Korisnik : IEntity
	{
        public int IdUsera { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Uloga { get; set; }
        public string TableName => "Korisnik";

		public string DisplayValue => Username;

		public string PrimaryKey => IdUsera.ToString();

		public string GetByIDQuery()
		{
			return $"Username='{Username}' AND Password='{Password}'";
		}
		public IEntity GetReaderResult(SqlDataReader reader)
		{
			if (reader.Read())
			{
				Korisnik kor = new Korisnik { 
					IdUsera = (int)reader["IdUser"],
					Username =(string) reader["Username"],
					Password = (string)reader["Password"],
					Uloga = (string)reader["Uloga"],
				};
				return kor;
			}
			return null;
		}

		public string GetFilterQuery(string filter)
		{
			throw new NotImplementedException();
		}

		public string GetParametres()
		{
			throw new NotImplementedException();
		}

		public List<IEntity> GetReaderList(SqlDataReader reader)
		{
			throw new NotImplementedException();
		}

		public string GetSearchAttributes()
		{
			throw new NotImplementedException();
		}

		public string JoinQuery()
		{
			throw new NotImplementedException();
		}

		public void PrepareCommand(SqlCommand cmd)
		{
			throw new NotImplementedException();
		}

		public List<IEntity> ReadAllSearch(SqlDataReader reader)
		{
			throw new NotImplementedException();
		}

		public string UpdateQuery()
		{
			throw new NotImplementedException();
		}
	}
}
