
using Assets.Scripts.GameCore.Fields;
using System;
using UnityEngine;

namespace Assets.Scripts.Views
{
    internal class UIHeroSelector : MonoBehaviour, IInteractable
    {
        public event Action<object> OnInteract;
        public void OnHeroClicked(Coord heroCoord)
        {
            OnInteract?.Invoke(heroCoord);
        }
    }
}
