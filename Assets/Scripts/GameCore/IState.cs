using Assets.Scripts.Cmd;

namespace GameCore
{
    public interface IState:ICommandHandler<ICommand>
    {
        void Enter();
        void Exit();
    }
}