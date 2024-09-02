
using System;
using UnityEngine;

namespace Assets.Scripts.Views
{
    internal class UIHeroSelector : MonoBehaviour, IInteractable
    {
        public event Action<object> OnInteract;
        public void OnHeroClicked((int,int) heroCoord)
        {
            OnInteract?.Invoke(heroCoord);
        }
    }
}
