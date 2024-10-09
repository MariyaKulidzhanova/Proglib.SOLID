using Proglib.SOLID.Interfaces.Implementation;
using Proglib.SOLID.Models;

namespace Proglib.SOLID.Interfaces
{
    public interface MoveCommandEndable
    {
        MoveCommand GetMoveCommand();
        UObject GetUObject();
        Queue<Command> GetCommandQueue();
    }
}