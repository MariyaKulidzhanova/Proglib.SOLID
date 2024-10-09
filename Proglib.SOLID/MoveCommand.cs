namespace Proglib.SOLID
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