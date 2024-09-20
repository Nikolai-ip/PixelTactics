using Assets.Scripts.Cmd;
using Assets.Scripts.GameCore.Fields;

namespace Assets.Scripts.GameCore.Commands
{
    internal class SelectHero : IPlayerCommand
    {
        public SelectHero(Coord heroCoord)
        {
            HeroCoord = heroCoord;
        }

        public Coord HeroCoord { get; }

        public int ActionCost => 0;
    }
}
