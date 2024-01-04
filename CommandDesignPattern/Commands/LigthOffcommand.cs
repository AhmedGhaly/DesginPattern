using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommendPattern.Commands
{
    public class LigthOffcommand : Command
    {
        Ligth ligth;

        public LigthOffcommand(Ligth ligth)
        {
            this.ligth = ligth;
        }

        public void excute()
        {
            ligth.off();
        }

        public void undo()
        {
            ligth.on();
        }
    }
}
