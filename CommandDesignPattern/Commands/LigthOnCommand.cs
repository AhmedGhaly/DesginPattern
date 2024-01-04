using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommendPattern.Commands
{
    public class LigthOnCommand : Command
    {
        Ligth ligth;
        public LigthOnCommand(Ligth ligth)
        {
            this.ligth = ligth;
        }

        public void excute()
        {
            ligth.on();
        }

        public void undo()
        {
            ligth.off();
        }
    }
}
