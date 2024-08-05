using System.Collections.Generic;
using GameCore.Cards;
using JetBrains.Annotations;

namespace GameCore.Fields
{
    public abstract class Field : IService
    {
        protected List<List<Card>> _field;
    
        public readonly int SizeX;
        public readonly int SizeY;

        public Field(int sizeX, int sizeY)
        {
            SizeX = sizeX;
            SizeY = sizeY;
        
            InitField();
        }

        [CanBeNull] 
        public abstract Card this[int i, int j] { get; set; }

        public void MoveTo(Field field)
        {
            field._field = _field;
            _field = null;
        }
    
        private void InitField()
        {
            for (int i = 0; i < SizeY; i++)
            {
                _field[i] = new List<Card>(SizeX);
            }
        }
    }
}