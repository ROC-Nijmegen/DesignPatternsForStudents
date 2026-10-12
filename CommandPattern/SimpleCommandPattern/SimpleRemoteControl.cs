using VendorClasses;

namespace SimpleCommandPattern
{
    internal class SimpleRemoteControl
    {
        Command slot;
        public SimpleRemoteControl()
        {

        }

        public void SetCommand(Command command) 
        { 
            slot = command;
        }

        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }
}
