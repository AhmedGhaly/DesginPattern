using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommendPattern.Commands
{
    public class Ligth
    {
        public void on()
        {
            Console.WriteLine("the ligth is on");

        }
        public void off()
        {
            Console.WriteLine("the ligth is off");
        }
    }
}
