using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSoft_projekat_2020_0125.SystemOperation.SOTermin
{
	internal class KreirajTerminZaMusterijuSO : SystemOperationBase
	{
		private readonly List<DetaljiTermina> detaljiTermina;
        public KreirajTerminZaMusterijuSO(List<DetaljiTermina> dt)
        {
            detaljiTermina = dt;
        }
        protected override void ExecuteConcreteOperation()
		{
			int id=broker.ReturnIdAdd(detaljiTermina[0].Termin);
			foreach(DetaljiTermina dTermina in detaljiTermina)
			{
				dTermina.Termin.IdTermina = id;
				broker.Add(dTermina);
			}
		}
	}
}
