using VendorClasses;

namespace SimpleCommandPattern.Classes.Commands
{
    internal class GarageDoorDownCommand : Command
    {
        GarageDoor garageDoor;
        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void Execute()
        {
        }

        public void Undo()
        {
        }
    }
}
