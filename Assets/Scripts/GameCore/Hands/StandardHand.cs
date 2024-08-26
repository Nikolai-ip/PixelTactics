using Assets.Scripts.GameCore.HeroModule;

namespace GameCore.Hands
{
    class StandardHand : Hand
    {
        public override Hero this[int i]
        {
            get => Heroes[i];
            set => Heroes[i] = value;
        }
    }
}