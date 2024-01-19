using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSoft_projekat_2020_0125.SystemOperation.SOUsluga
{
	internal class NadjiUslugeSO : SystemOperationBase
	{
		private readonly string Filter;
        public List<IEntity> result { get; set; }
        public NadjiUslugeSO(string filter)
        {
			Filter = filter;
        }
        protected override void ExecuteConcreteOperation()
		{
			result=broker.GetAllByFilter(new Usluga(), Filter);
		}
	}
}
