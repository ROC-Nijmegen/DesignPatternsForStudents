using VendorClasses;

namespace CommandPattern.Commands
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
