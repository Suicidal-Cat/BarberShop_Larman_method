using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSoft_projekat_2020_0125.SystemOperation.SOMusterija
{
	internal class KreirajNalogMusterijeSO : SystemOperationBase
	{
		private readonly Musterija musterija;
        public KreirajNalogMusterijeSO(Musterija m)
		{
            musterija = m;
        }
        protected override void ExecuteConcreteOperation()
		{
			broker.Add(musterija);
		}
	}
}
