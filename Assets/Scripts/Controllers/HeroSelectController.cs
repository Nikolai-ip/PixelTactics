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
        private IInteractable<SelectHero> _uiSelector;
        public void Init(ICommandHandler<ICommand> commandHandler)
        {
            DataUpdateBus.Subscribe<HeroContainer>(OnHeroSelected);
            _commandHandler = commandHandler;
            _uiSelector.OnInteract += HandleHeroSelection;
        }
        public void HandleHeroSelection(SelectHero selectSignal)
        {
            _commandHandler.TryHandle(new SelectHero(selectSignal.HeroCoord));
        }
        private void OnHeroSelected(HeroContainer heroContainer)
        {
            var hero = heroContainer.Hero;
        }
    }
}
