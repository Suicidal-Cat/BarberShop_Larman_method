using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSoft_projekat_2020_0125.SystemOperation.SOUsluga
{
	internal class IzmeniUsluguSO : SystemOperationBase
	{
		private readonly Usluga usluga;
        public IzmeniUsluguSO(Usluga u)
        {
			usluga = u;
        }
        protected override void ExecuteConcreteOperation()
		{
			broker.Update(usluga);
		}
	}
}
