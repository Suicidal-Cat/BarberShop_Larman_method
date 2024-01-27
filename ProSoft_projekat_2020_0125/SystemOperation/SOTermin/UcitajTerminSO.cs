using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSoft_projekat_2020_0125.SystemOperation.SOTermin
{
	internal class UcitajTerminSO : SystemOperationBase
	{
		private readonly Termin termin;
        public List<IEntity> result { get; set; }
        public UcitajTerminSO(Termin t)
        {
            termin = t;
        }
        protected override void ExecuteConcreteOperation()
		{
			result= broker.ReadAllSearch(new DetaljiTermina { Termin = termin });
		}
	}
}
