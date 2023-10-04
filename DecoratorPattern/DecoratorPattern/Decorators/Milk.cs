using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.DecoratorPattern.Decorators
{
    internal class Milk:Decorator
    {
        public override double Cost()
        {
            return 0.1 + this.behior.Cost();
        }
        public override string GetDescription()
        {
            return behior.GetDescription() + ", Milk";
        }
        internal Milk(Behior behior)
        {
            this.behior = behior;
        }

    }
}
