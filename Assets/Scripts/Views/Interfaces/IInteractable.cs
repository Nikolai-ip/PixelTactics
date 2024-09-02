
using System;

namespace Assets.Scripts.Views
{
    internal interface IInteractable
    {
        event Action<object> OnInteract;
    }
}
