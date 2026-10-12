using VendorClasses;

namespace SimpleCommandPattern.Classes.Commands
{
    internal class StereoOnWithCDCommand : Command
    {
        Stereo stereo;
        public StereoOnWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
        }

        public void Undo()
        {
        }
    }
}
