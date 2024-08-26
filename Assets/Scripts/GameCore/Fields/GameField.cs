using Assets.Scripts.GameCore.HeroModule;
using JetBrains.Annotations;
using System;

namespace GameCore.Fields
{
    public class GameField : IService
    {
        protected Cell[,] _cells;
    
        public readonly int SizeX;
        public readonly int SizeY;

        public GameField(int sizeX, int sizeY)
        {
            SizeX = sizeX;
            SizeY = sizeY;
        
            InitField();
        }

        [CanBeNull] 
        public Cell this[int i, int j] { get => _cells[i, j];}
        private void InitField()
        {
            for (int i = 0; i < SizeY; i++)
            {
                for (int j =0 ; j < SizeX; j++)
                {
                    _cells[i, j] = new Cell();
                }
            }
        }
        public bool TryHireHero(Tuple<int,int> coord, Hero hero)
        {
            int x = coord.Item1;    
            int y = coord.Item2;

            if (_cells[x, y].IsBusy)
                return false;

            _cells[x,y].SetHero(hero);
            return true;
        }

    }
}