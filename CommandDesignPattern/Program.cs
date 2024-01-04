using CommendPattern.Commands;

namespace CommendPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Ligth ligth = new Ligth();

            LigthOnCommand ligthOnCommand = new LigthOnCommand(ligth);
            LigthOffcommand ligthOffCommand = new LigthOffcommand(ligth);

            RemoteComtroller remoteController = new RemoteComtroller(7);

            remoteController.setCommand(1, ligthOnCommand, ligthOffCommand);

            remoteController.offButtonPressed(1);
            remoteController.undoButtonPressed();
           
            remoteController.offButtonPressed(2);
        }
    }
}
