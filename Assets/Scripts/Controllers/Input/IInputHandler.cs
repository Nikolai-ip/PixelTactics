using System;
using Assets.Scripts.Cmd;
using Infrastructure.Services;

namespace Controllers.Input
{
    public interface IInputHandler:IService
    {
        public event Action<ICommand> CommandCalled;
    }
}