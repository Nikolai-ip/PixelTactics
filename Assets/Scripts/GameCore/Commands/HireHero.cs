using Assets.Scripts.Cmd;
using Assets.Scripts.GameCore.Fields;
using Assets.Scripts.GameCore.HeroModule;

namespace Assets.Scripts.GameCore.Commands
{
    public class HireHero : IPlayerCommand
    {
        public HireHero(Coord hireCoord, Hero hero)
        {
            HireCoord = hireCoord;
            Hero = hero;
        }

        public Coord HireCoord { get; private set; }
        public Hero Hero { get; private set; }

        public int ActionCost => 1;
    }
}
