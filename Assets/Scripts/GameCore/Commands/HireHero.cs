using Assets.Scripts.GameCore.Fields;
using Assets.Scripts.GameCore.HeroModule;
using GameCore.Fields;
using Infrastructure.Cmd;

namespace GameCore.Commands
{
    public class HireHero : ICommand
    {
        public HireHero(GameField field, Coord hireCoord, Hero hero)
        {
            HireCoord = hireCoord;
            Hero = hero;
        }

        public Coord HireCoord { get; }
        public Hero Hero { get; }
    }
}
