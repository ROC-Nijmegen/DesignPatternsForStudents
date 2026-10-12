using VendorClasses;

namespace SimpleCommandPattern.Classes.Commands
{
    internal class NoCommand : Command
    {
        public void Execute()
        {
        }

        public void Undo()
        {
        }
    }
}
