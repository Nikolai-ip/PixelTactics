using Assets.Scripts.GameCore.Fields;
using UnityEngine;

namespace Views
{
    internal class UICell:MonoBehaviour
    {
        [SerializeField] private int _x;
        [SerializeField] private int _y;
        public Coord Coord => new Coord(_x,_y);
    }
}
