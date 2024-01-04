using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Expresso : Beverage
    {
        public override double cost()
        {
            return 1.99;
        }

    }
}
