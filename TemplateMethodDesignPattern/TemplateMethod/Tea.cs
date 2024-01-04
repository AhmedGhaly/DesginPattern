using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Tea : CaffienDrink
    {
        public override void add()
        {
            Console.WriteLine("adding lemon");
        }

        public override void brew()
        {
            Console.WriteLine("steeping the tea");
        }

    }
}
