using VendorClasses;

namespace SimpleCommandPattern.Commands
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
