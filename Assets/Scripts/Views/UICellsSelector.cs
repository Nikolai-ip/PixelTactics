using GameCore.Commands;
using GameCore.Fields;
using Infrastructure.Cmd;
using Presenter.Input;
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