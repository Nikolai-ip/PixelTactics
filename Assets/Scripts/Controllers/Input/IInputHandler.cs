using System;
using Infrastructure.Cmd;
using Infrastructure.Services;

namespace Controllers.Input
{
    public interface IInputHandler:IService
    {
        event Action<ICommand> CommandCalled;
        void OnCommand(ICommand command);
    }
}