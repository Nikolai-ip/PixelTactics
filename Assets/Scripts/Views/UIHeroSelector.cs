using Assets.Scripts.GameCore.Fields;
using System;
using Assets.Scripts.GameCore.Commands;
using UnityEngine;

namespace Assets.Scripts.Views
{
    internal class UIHeroSelector : MonoBehaviour, IInteractable<SelectHero>
    {
        public event Action<SelectHero> OnInteract;
        public void OnHeroClicked(Coord heroCoord)
        {
            OnInteract?.Invoke(new SelectHero(heroCoord));
        }
    }
}
