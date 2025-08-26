using Infrastructure.Cmd;

namespace GameCore
{
    public interface IModelCommandHandler
    {
        bool TryHandle(ICommand command);
    }
}