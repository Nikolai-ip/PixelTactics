using System;
using Assets.Scripts.Cmd;
using Infrastructure.Cmd;

namespace Views.Interfaces
{
    internal interface IInteractable<TCommand> where TCommand:ICommand
    {
        event Action<TCommand> OnInteract;
    }
}
