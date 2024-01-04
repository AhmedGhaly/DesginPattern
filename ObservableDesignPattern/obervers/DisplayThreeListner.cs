using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable.obervers
{
    internal class DisplayThreeListner : Observers
    {
        public void onUpdate(object sender, Argus args)
        {
            Console.WriteLine($"the caller is {sender as Weather} \t [from display three] and the tempture is {args.tempture} and the humanity is {args.humaity}");
        }
    }
}
