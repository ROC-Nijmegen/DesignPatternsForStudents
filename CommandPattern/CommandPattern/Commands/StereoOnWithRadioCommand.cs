using VendorClasses;

namespace CommandPattern.Classes.Commands
{
    internal class StereoOnWithRadioCommand : Command
    {
        Stereo stereo;
        public StereoOnWithRadioCommand(Stereo stereo)
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
