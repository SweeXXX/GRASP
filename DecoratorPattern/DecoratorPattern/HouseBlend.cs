using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.DecoratorPattern
{
    internal class HouseBlend: Behior
    {
        public override double Cost()
        {
            return 16;
        }
        public HouseBlend()
        {
            name = "HouseBlend";
        }
    }
}
