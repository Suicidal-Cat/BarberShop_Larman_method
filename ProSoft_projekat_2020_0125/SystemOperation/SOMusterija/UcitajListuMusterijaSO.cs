using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSoft_projekat_2020_0125.SystemOperation.SOMusterija
{
	internal class UcitajListuMusterijaSO : SystemOperationBase
	{
        public List<IEntity> Result { get; set; }
        protected override void ExecuteConcreteOperation()
		{
			Result=broker.ReadAll(new Musterija());
		}
	}
}
