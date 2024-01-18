using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSoft_projekat_2020_0125.SystemOperation.SOFrizer
{
	internal class IzmeniFrizeraSO : SystemOperationBase
	{
        public Frizer Frizer { get; set; }
		public IzmeniFrizeraSO(Frizer frizer)
		{
			Frizer = frizer;
		}
        protected override void ExecuteConcreteOperation()
		{
			broker.Update(Frizer);
		}
	}
}
