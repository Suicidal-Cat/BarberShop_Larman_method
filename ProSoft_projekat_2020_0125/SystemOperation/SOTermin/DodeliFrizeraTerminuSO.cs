using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSoft_projekat_2020_0125.SystemOperation.SOTermin
{
	internal class DodeliFrizeraTerminuSO : SystemOperationBase
	{
		private readonly Termin termin;
        public DodeliFrizeraTerminuSO(Termin t)
        {
            termin = t;
        }
        protected override void ExecuteConcreteOperation()
		{
			broker.Update(termin);
		}
	}
}
