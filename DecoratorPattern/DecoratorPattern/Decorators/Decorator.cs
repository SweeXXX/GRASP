using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.DecoratorPattern.Decorators
{
    public abstract class Decorator:Behior
    {
        protected Behior behior;
        public abstract override string GetDescription();
    }
}
