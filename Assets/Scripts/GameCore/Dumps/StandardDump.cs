using GameCore.Cards;

namespace GameCore.Dumps
{
    class StandardDump : Dump
    {
        public override Card this[int i]
        {
            get => _cards[i];
            set => _cards[i] = value;
        }
    }
}