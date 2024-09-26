using Assets.Scripts.GameCore.Fields;
using Assets.Scripts.GameCore.HeroModule;
using Infrastructure.Cmd;

namespace GameCore.Commands
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
