using Assets.Scripts.Cmd;

namespace GameCore
{
    public interface IState
    {
        void Enter();
        void Exit();
        void HandleInput(ICommand command);
    }
}