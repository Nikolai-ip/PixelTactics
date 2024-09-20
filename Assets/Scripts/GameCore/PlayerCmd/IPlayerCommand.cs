namespace Assets.Scripts.Cmd
{
    public interface IPlayerCommand:ICommand
    {
        int ActionCost { get; }
    }
}
