using System;
using Assets.Scripts.Cmd;
using Infrastructure.Services;
using UnityEngine;

namespace Controllers.Input
{
    public class MouseInputHandler:IInputHandler
    {
        public event Action<ICommand> CommandCalled;
    }
    
}