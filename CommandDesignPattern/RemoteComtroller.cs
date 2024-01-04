using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommendPattern.Commands;

namespace CommendPattern
{
    internal class RemoteComtroller
    {
        Command[] onSlots;
        Command[] offSlots;

        Command lasCommand;

        int size;

        public RemoteComtroller(int size)
        {
            this.size = size;
            onSlots = new Command[size];
            offSlots = new Command[size];

            lasCommand = new NoCommand();

            for (int i = 0; i < size; i++)
            {
                onSlots[i] = new NoCommand();
                offSlots[i] = new NoCommand();
            }
        }
        
        public void setCommand(int slot, Command onCommmand, Command offCommand)
        {
            if(slot > 0 && slot <= size)
            {
                onSlots[slot] = onCommmand;
                offSlots[slot] = offCommand;
            }
        }

        public void onButtonPressed(int slot) {
            if(slot > 0 && slot <= size)
            {
                onSlots[slot].excute();
                lasCommand = onSlots[slot];
            }
        }

        public void offButtonPressed(int slot)
        {
            if (slot > 0 && slot <= size)
            {
                offSlots[slot].excute();
                lasCommand = offSlots[slot];

            }
        }

        public void undoButtonPressed()
        {
            if (lasCommand is not null)
            {
                lasCommand.undo();

            }
        }
    }
}
