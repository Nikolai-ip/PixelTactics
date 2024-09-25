using System;
using Assets.Scripts.Cmd;
using Assets.Scripts.GameCore.Commands;
using Assets.Scripts.GameCore.Fields;
using Assets.Scripts.Views;
using EventBus;
using EventBus.Signals;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    internal class HeroSelectController:MonoBehaviour
    {
        private ICommandHandler<ICommand> _commandHandler;
        private IInteractable<SelectHero> _heroSelector;
        public void Init(ICommandHandler<ICommand> commandHandler,IInteractable<SelectHero> heroSelector)
        {
            DataUpdateBus.Subscribe<HeroContainer>(OnHeroSelected);
            _commandHandler = commandHandler;
            _heroSelector = heroSelector;
            _heroSelector.OnInteract += HandleHeroSelection;
        }
        public void HandleHeroSelection(SelectHero selectSignal)
        {
            _commandHandler.TryHandle(new SelectHero(selectSignal.HeroCoord));
        }
        private void OnHeroSelected(HeroContainer heroContainer)
        {
            var hero = heroContainer.Hero;
            Debug.Log(hero.Name);
        }
    }
}
