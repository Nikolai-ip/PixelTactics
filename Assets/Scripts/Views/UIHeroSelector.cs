using GameCore.Commands;
using GameCore.Fields;
using Presenter.Input;
using UnityEngine;

namespace Views
{
    internal class UIHeroSelector : MonoBehaviour
    {
        private IInputHandler _inputHandler;
        public void Init(IInputHandler input)
        {
            _inputHandler = input;
        }
        public void OnHeroClicked(Coord heroCoord)
        {
            _inputHandler.OnCommand(new SelectHero(heroCoord));
        }
        
    }
}
