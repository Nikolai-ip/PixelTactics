using Assets.Scripts.Cmd;
using Assets.Scripts.GameCore.Fields;
using Assets.Scripts.GameCore.HeroModule;

namespace Assets.Scripts.GameCore.Commands
{
    public class HireHero : ICommand
    {
        public HireHero(Coord hireCoord, Hero hero)
        {
            HireCoord = hireCoord;
            Hero = hero;
        }

        public Coord HireCoord { get; }
        public Hero Hero { get; }
    }
}
