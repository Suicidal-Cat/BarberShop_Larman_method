using Common.Domain;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSoft_projekat_2020_0125.SystemOperation.SOTermin
{
	internal class NadjiTermineSO : SystemOperationBase
	{
		private readonly string filter;
        public List<IEntity> result { get; set; }
        public NadjiTermineSO(string filter)
        {
            this.filter = filter;
        }
		protected override void ExecuteConcreteOperation()
		{
			result=broker.GetAllByFilter(new Termin(),filter);
		}
	}
}
