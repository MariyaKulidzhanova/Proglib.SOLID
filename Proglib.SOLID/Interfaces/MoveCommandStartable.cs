using Proglib.SOLID.Models;

namespace Proglib.SOLID.Interfaces
{
    public interface MoveCommandStartable
    {
        UObject GetUObject();
        int GetVelocity();
        Queue<Command> GetCommandQueue();
    }
}