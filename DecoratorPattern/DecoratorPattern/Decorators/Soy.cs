using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.DecoratorPattern.Decorators
{
    internal class Soy: Decorator
    {
        public override double Cost()
        {
            return 12 + behior.Cost();
        }
        public override string GetDescription()
        {
            return behior.GetDescription() + ", Soy";
        }
        public Soy(Behior behior) 
        {
            this.behior = behior;
        }
    }
}
