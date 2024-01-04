using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class CaffienDrink
    {
        public void prepare()
        {
            bolingWater();
            brew();
            pouring();
          
              add();

        }
        public void bolingWater()
        {
            Console.WriteLine("bolling water");
        }
        public abstract void brew();
        public void pouring()
        {
            Console.WriteLine("pouring into the cup");
        }
        public abstract void add();
    }
}
