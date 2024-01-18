using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSoft_projekat_2020_0125.SystemOperation.SOFrizer
{
	internal class NadjiFrizereSO : SystemOperationBase
	{
        public List<IEntity> result { get; set; }
        public string Filter { get; set; }
        public NadjiFrizereSO(string filter)
        {
            Filter=filter;
        }

        protected override void ExecuteConcreteOperation()
		{
            result = broker.GetAllByFilter(new Frizer(), Filter);
        }
	}
}
