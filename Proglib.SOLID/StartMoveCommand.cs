namespace Proglib.SOLID
{
    public class StartMoveCommand : Command
    {
        private MoveCommandStartable moveCommandStartable;

        public StartMoveCommand(MoveCommandStartable moveCommandStartable)
        {
            this.moveCommandStartable = moveCommandStartable;
        }

        public void Execute()
        {
            var uObject = moveCommandStartable.GetUObject();
            var velocity = moveCommandStartable.GetVelocity();
            var commandQueue = moveCommandStartable.GetCommandQueue();

            uObject.SetVelocity(velocity);
            var moveCommand = new MoveCommand(uObject);
            commandQueue.Enqueue(moveCommand);
        }
    }
}