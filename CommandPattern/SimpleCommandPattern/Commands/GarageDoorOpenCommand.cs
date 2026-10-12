using VendorClasses;

namespace SimpleCommandPattern.Commands
{
    internal class GarageDoorOpenCommand : Command
    {
        GarageDoor garageDoor;
        public GarageDoorOpenCommand(GarageDoor garageDoor)
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
