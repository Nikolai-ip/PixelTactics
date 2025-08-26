using GameCore.HeroModule;

namespace Infrastructure.EventBus.Signals
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