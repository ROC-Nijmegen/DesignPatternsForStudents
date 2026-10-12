using VendorClasses;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanOffCommand : Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
        }

        public void Execute()
        {
        }

        public void Undo()
        {
        }
    }
}
