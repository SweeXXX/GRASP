using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.DecoratorPattern
{
    internal class DarkRoast : Behior
    {
        public override double Cost()
        {
            return 0.3;
        }
        public DarkRoast()
        {
            name = "DarkRoast";
        }
    }
}
