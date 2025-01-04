using System;
using UnityEngine;

namespace Views.Card
{
    public class CardPresenter:MonoBehaviour
    {
        public void OnMouseUp()
        {
            Debug.Log("Up");
            OnInteract?.Invoke();
        }
        public event Action OnInteract;
    }
}