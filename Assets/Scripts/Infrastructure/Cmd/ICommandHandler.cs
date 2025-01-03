using Infrastructure.Services;

namespace Infrastructure.Cmd
{
    public interface ICommandHandler<TCommand>:IService,ICommandHandler where TCommand:ICommand
    {
        bool TryHandle(TCommand command); 
    }

    public interface ICommandHandler
    {
        bool TryHandle(ICommand command);
    }
}
