using Assets.Scripts.GameCore.Fields;
using Controllers.Input;
using GameCore.Commands;
using Infrastructure.Cmd;
using UnityEngine;

namespace Views
{
    public class UICellsSelector:MonoBehaviour
    {
        private IInputHandler _inputHandler;
        public void Init(IInputHandler input)
        {
            _inputHandler = input;
        }
        public void OnCellClicked(Coord heroCoord)
        {

        }
    }
    
}