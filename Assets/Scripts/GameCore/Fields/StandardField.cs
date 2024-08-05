using GameCore.Cards;

namespace GameCore.Fields
{
    public class StandardField : Field
    {
        public StandardField(int sizeX, int sizeY) : base(sizeX, sizeY) { }

        public override Card this[int i, int j]
        {
            get => _field[i][j];
            set => _field[i][j] = value;
        }
    }
}