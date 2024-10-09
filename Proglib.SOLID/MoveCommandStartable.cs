namespace Proglib.SOLID
{
    public interface MoveCommandStartable
    {
        UObject GetUObject();
        int GetVelocity();
        Queue<Command> GetCommandQueue();
    }
}