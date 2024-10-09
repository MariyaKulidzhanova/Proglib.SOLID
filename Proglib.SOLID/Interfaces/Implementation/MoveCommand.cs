using Proglib.SOLID.Models;

namespace Proglib.SOLID.Interfaces.Implementation
{
    public class MoveCommand : Command
    {
        private UObject uObject;

        public MoveCommand(UObject uObject)
        {
            this.uObject = uObject;
        }

        public void Execute()
        {
            // Moves the object with velocity
        }
    }
}