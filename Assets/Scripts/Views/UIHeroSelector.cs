using Assets.Scripts.GameCore.Fields;
using Controllers.Input;
using GameCore.Commands;
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
