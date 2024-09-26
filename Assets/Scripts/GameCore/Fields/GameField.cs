using Assets.Scripts.GameCore.Fields;
using Assets.Scripts.GameCore.HeroModule;
using Infrastructure.Services;

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
        public Cell this[int i, int j] { get => _cells[i, j];}
        private void InitField()
        {
            _cells = new Cell[SizeX, SizeY];
            for (int i = 0; i < SizeY; i++)
            {
                for (int j =0 ; j < SizeX; j++)
                {
                    _cells[i, j] = new Cell();
                }
            }
        }
        public bool TryHireHero(Coord coord, Hero hero)
        {
            int x = coord.X;    
            int y = coord.Y;

            if (_cells[x, y].IsBusy)
                return false;

            _cells[x,y].SetHero(hero);
            return true;
        }
        
    }
}