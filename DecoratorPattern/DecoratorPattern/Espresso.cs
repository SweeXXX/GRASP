using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.DecoratorPattern
{
    internal class Espresso:Behior
    {
        public override double Cost()
        {
            return 0.7;
        }
        public Espresso() 
        {
            this.name = "Espresso";
        }
    }
}
