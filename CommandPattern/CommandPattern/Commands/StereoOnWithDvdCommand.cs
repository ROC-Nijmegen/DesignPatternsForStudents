using VendorClasses;

namespace CommandPattern.Commands
{
    internal class StereoOnWithDvdCommand : Command
    {
        Stereo stereo;
        public StereoOnWithDvdCommand(Stereo stereo)
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
