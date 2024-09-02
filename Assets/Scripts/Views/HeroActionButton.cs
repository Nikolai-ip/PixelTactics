using Assets.GameCore.HeroModule;
using System;
using UnityEngine;

namespace Assets.Scripts.Views
{
    internal class HeroActionButton : MonoBehaviour, IInteractable
    {
        public event Action<object> OnInteract;
        [SerializeField] private HeroAction _action;
        public void OnClick()
        {
            OnInteract?.Invoke(_action);
        }
    }
}
