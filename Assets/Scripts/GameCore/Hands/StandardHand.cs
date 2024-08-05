using GameCore.Cards;

namespace GameCore.Hands
{
    class StandardHand : Hand
    {
        public override Card this[int i]
        {
            get => _cards[i];
            set => _cards[i] = value;
        }
    }
}