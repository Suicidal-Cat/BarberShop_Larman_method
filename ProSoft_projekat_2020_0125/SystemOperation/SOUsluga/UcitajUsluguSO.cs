using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSoft_projekat_2020_0125.SystemOperation.SOUsluga
{
	
	internal class UcitajUsluguSO : SystemOperationBase
	{
		private readonly Usluga usluga;
        public IEntity result { get; set; }
        public UcitajUsluguSO(Usluga u)
        {
			usluga = u;
		}
        protected override void ExecuteConcreteOperation()
		{
			result = broker.GetEntityById(usluga);
		}
	}
}
