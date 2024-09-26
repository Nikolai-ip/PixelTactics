using System;
using Assets.Scripts.GameCore.HeroModule;
using UnityEngine;

namespace Views.Card
{
    public class CardPresenter:MonoBehaviour
    {
        private Hero _hero;
        public void OnMouseUp()
        {
            Debug.Log("Up");
            OnInteract?.Invoke();
        }
        public event Action OnInteract;
    }
}