using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
	public interface IEntity
	{
		string TableName { get; }
		string Values { get; }// bez ovoga?
		List<IEntity> GetReaderList(SqlDataReader reader);
		IEntity GetReaderResult(SqlDataReader reader);
		string GetParametres();
		void PrepareCommand(SqlCommand cmd);
		string UpdateQuery();
		string GetByIDQuery();
	}
}
