using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProSoft_projekat_2020_0125.SystemOperation
{
	internal class KreirajNalogFrizeraSO : SystemOperationBase
	{
		private readonly Frizer frizer;
		public KreirajNalogFrizeraSO(Frizer frizer)
		{
			this.frizer = frizer;
		}

		protected override void ExecuteConcreteOperation()
		{
			broker.Add(frizer);
		}
	}
}
