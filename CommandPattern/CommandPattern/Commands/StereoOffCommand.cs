using VendorClasses;

namespace CommandPattern.Classes.Commands
{
    internal class StereoOffCommand : Command
    {
        Stereo stereo;
        public StereoOffCommand(Stereo stereo)
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
