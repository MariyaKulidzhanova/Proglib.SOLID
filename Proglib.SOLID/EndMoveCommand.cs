namespace Proglib.SOLID
{
    public class EndMoveCommand : Command
    {
        private MoveCommandEndable moveCommandEndable;

        public EndMoveCommand(MoveCommandEndable moveCommandEndable)
        {
            this.moveCommandEndable = moveCommandEndable;
        }

        public void Execute()
        {
            var uObject = moveCommandEndable.GetUObject();
            var commandQueue = moveCommandEndable.GetCommandQueue();
            var moveCommand = moveCommandEndable.GetMoveCommand();

            uObject.RemoveVelocity();

            // Remove the moveCommand from the command queue
            var tempQueue = new Queue<Command>();
            while (commandQueue.Count > 0)
            {
                var command = commandQueue.Dequeue();
                if (command != moveCommand)
                {
                    tempQueue.Enqueue(command);
                }
            }

            while (tempQueue.Count > 0)
            {
                commandQueue.Enqueue(tempQueue.Dequeue());
            }
        }
    }
}