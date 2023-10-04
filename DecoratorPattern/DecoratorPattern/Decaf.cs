using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.DecoratorPattern
{
    internal class Decaf:Behior
    {
        public override double Cost()
        {
            return 5;
        }
        public Decaf()
        {
            this.name = "Decaf";
        }
    }
}
