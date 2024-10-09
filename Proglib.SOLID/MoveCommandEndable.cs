namespace Proglib.SOLID
{
    public interface MoveCommandEndable
    {
        MoveCommand GetMoveCommand();
        UObject GetUObject();
        Queue<Command> GetCommandQueue();
    }
}