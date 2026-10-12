using SimpleCommandPattern.Interfaces;

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
