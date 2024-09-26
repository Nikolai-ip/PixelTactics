using Assets.Scripts.GameCore.Fields;
using Infrastructure.Cmd;

namespace GameCore.Commands
{
    internal class SelectHero : ICommand
    {
        public SelectHero(Coord heroCoord)
        {
            HeroCoord = heroCoord;
        }
        public Coord HeroCoord { get; }
    }
}
