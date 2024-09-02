using System;
using UnityEngine;

namespace Assets.Scripts.Views
{
    internal class UICell:MonoBehaviour
    {
        [SerializeField] private int _x;
        [SerializeField] private int _y;
        public (int,int) Coord => (_x, _y);
    }
}
