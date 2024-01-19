using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSoft_projekat_2020_0125.SystemOperation.SOFrizer
{
	internal class UcitajFrizeraSO : SystemOperationBase
	{
        public IEntity result { get; set; }
        public int Id { get; set; }
        public UcitajFrizeraSO(int id)
        {
            Id = id;
        }
        protected override void ExecuteConcreteOperation()
		{
            result = broker.GetEntityById(new Frizer() { IdFrizera = Id });
		}
	}
}
