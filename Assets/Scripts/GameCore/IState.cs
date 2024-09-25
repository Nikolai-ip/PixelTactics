using System;
using Assets.Scripts.Cmd;

namespace GameCore
{
    public interface IState:IExitableState
    {
        void Enter();
    }
    public interface IPayLoadedState<TPayload>:IExitableState
    {
        void Enter(TPayload payload);
    }

    public interface IExitableState:ICommandHandler<ICommand>
    {
        void Exit();
    }
}