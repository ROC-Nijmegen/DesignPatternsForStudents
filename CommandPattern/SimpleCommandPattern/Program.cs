using SimpleCommandPattern.Classes.Commands;

namespace SimpleCommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            // TODO: Create an instance of Light
            // TODO: Create an instance of LightOnCommand, providing the previous instance of Light as an argument
            // TODO: Create an instance of LightOffCommand, providing the previous instance of Light as an argument
            // TODO: Set the command to the LightOnCommand instance

            remote.ButtonWasPressed();

            // TODO:Set the command to the LightOffCommand instance
            remote.ButtonWasPressed();

            // TODO: Without making another SimpleRemoteControl instance, do the same for the GarageDoorOpenCommand
            // TODO: Extensively test the SimpleRemoteControl
        }
    }
}