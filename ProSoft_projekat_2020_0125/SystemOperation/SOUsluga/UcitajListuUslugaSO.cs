using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSoft_projekat_2020_0125.SystemOperation.SOUsluga
{
	internal class UcitajListuUslugaSO : SystemOperationBase
	{
        public List<IEntity> result { get; set; }
        public bool ReadAll { get; set; }
        public UcitajListuUslugaSO(bool allAttributes=false)
        {
			ReadAll = allAttributes;
        }
        protected override void ExecuteConcreteOperation()
		{
            if (ReadAll)
            {
                result = broker.ReadAll(new Usluga());
			}
            else result = broker.ReadAllSearch(new Usluga());
		}
	}
}
