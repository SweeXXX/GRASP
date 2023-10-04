using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.DecoratorPattern
{
    abstract public class Behior
    {
        protected string name = "Unknown Behior";
        public virtual string GetDescription()
        {
            return name;
        }
        abstract public double Cost();
    }
}
