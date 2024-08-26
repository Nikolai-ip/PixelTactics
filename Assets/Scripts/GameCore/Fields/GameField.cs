using System.Collections.Generic;
using GameCore.Cards;
using JetBrains.Annotations;

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
    }
}