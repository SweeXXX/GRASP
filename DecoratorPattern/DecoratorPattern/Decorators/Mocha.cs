using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.DecoratorPattern.Decorators
{
    internal class Mocha:Decorator
    {
        public Mocha(Behior behior) 
        {
            this.behior = behior;
        }
        public override string GetDescription()
        {
            return behior.GetDescription() + ", Mocha";
        }
        public override double Cost()
        {
            return 72 + behior.Cost();
        }
    }
}
