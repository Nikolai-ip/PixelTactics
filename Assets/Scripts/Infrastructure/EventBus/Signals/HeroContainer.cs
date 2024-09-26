using Assets.Scripts.GameCore.HeroModule;

namespace EventBus.Signals
{
    public class HeroContainer:ISignal
    {
        public HeroContainer(Hero hero)
        {
            Hero = hero;
        }

        public Hero Hero { get; }
        
    }
}