using VendorClasses;

namespace CommandPattern.Classes.Commands
{
    internal class LightOffCommand : Command
    {
        Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
        }
        public void Undo()
        {
        }
    }
}
