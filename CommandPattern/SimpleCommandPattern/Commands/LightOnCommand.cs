using VendorClasses;

namespace SimpleCommandPattern.Commands
{
    internal class LightOnCommand : Command
    {
        Light light;

        public LightOnCommand(Light light)
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
