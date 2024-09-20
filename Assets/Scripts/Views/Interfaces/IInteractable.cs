using System;
using Assets.Scripts.Cmd;

namespace Assets.Scripts.Views
{
    internal interface IInteractable<TCommand> where TCommand:ICommand
    {
        event Action<TCommand> OnInteract;
    }
}
