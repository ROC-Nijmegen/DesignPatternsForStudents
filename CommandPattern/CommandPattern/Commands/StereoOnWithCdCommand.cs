using VendorClasses;

namespace CommandPattern.Classes.Commands
{
    internal class StereoOnWithCdCommand : Command
    {
        Stereo stereo;
        public StereoOnWithCdCommand(Stereo stereo)
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
