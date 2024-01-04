using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommendPattern.Commands
{
    internal class NoCommand : Command
    {
        public void excute()
        {
            Console.WriteLine("there is no command to excute");
        }

        public void undo()
        {
            Console.WriteLine("no thing will doing");
        }
    }
}
