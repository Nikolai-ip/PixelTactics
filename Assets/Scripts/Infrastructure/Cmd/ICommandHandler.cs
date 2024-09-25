namespace Assets.Scripts.Cmd
{
    public interface ICommandHandler<TCommand> where TCommand:ICommand
    {
        bool TryHandle(TCommand command); 
    }
}
