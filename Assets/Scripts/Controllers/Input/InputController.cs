using System;
using Infrastructure.Cmd;

namespace Controllers.Input
{
    public class InputController:IInputHandler
    {
        public event Action<ICommand> CommandCalled;
        public void OnCommand(ICommand command)
        {
            
        }
    }
}