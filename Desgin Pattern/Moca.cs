using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Moca : Decorators
    {
        public Moca(Beverage beverage)
        {
            this.Beverage = beverage;   
        }
        Beverage Beverage { get; set; }
        public override double cost()
        {
            return 20+ Beverage.cost();
        }
    }
}
