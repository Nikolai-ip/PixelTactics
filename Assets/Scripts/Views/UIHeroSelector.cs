using System;
using Assets.Scripts.GameCore.Commands;
using Assets.Scripts.GameCore.Fields;
using UnityEngine;
using Views.Interfaces;

namespace Views
{
    internal class UIHeroSelector : MonoBehaviour, IInteractable<SelectHero>
    {
        public void OnHeroClicked(Coord heroCoord)
        {
            OnInteract?.Invoke(new SelectHero(heroCoord));
        }

        public event Action<SelectHero> OnInteract;
    }
}
