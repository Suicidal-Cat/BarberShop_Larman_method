using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSoft_projekat_2020_0125.SystemOperation.SOTermin
{
	internal class IzmeniTerminSO : SystemOperationBase
	{
		private readonly List<DetaljiTermina> detaljiTermina;
		public IzmeniTerminSO(List<DetaljiTermina> dt)
		{
			detaljiTermina = dt;
		}
		protected override void ExecuteConcreteOperation()
		{
			broker.Update(detaljiTermina[0].Termin);
			foreach (DetaljiTermina dTermina in detaljiTermina)
			{
				if(dTermina.Status=="Deleted")broker.Delete(dTermina);
				else if(dTermina.Status=="Added") broker.Add(dTermina);
			}
		}
	}
}
