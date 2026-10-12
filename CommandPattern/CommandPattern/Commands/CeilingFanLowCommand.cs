using VendorClasses;

namespace CommandPattern.Commands
{
    internal class CeilingFanLowCommand : Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanLowCommand(CeilingFan ceilingFan)
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
