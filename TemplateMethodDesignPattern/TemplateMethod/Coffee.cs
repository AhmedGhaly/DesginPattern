using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Coffee : CaffienDrink
    {
        public override void add()
        {
            Console.WriteLine("add milk and suger");
        }

        public override void brew()
        {
            Console.WriteLine("dripping the coffe hrough filter");
        }
    }
}
