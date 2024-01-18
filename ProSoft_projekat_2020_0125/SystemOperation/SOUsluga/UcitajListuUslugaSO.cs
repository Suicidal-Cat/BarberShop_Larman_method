using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSoft_projekat_2020_0125.SystemOperation.SOUsluga
{
	internal class UcitajListuUslugaSO : SystemOperationBase
	{
        public List<IEntity> result { get; set; }
        protected override void ExecuteConcreteOperation()
		{
			result = broker.ReadAllSearch(new Usluga());
		}
	}
}
