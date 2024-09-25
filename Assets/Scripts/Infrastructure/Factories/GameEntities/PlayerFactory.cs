using System.Collections.Generic;
using Assets.Scripts.GameCore.HeroModule;
using GameCore.Cards;
using GameCore.Fields;

namespace Infrastructure.Factories.GameEntities
{
    internal class PlayerFactory
    {
        public ServiceContainer Get(IEnumerable<Hero> Heroes,GameField gameField)
        {
            var player = new ServiceContainer();
            player.Register<Deck>(new StandardDeck(Heroes));
            player.Register<Hand>(new StandardHand());
            player.Register<Dump>(new StandardDump());
            player.Register<GameField>(gameField);
            return player;
        }
    }
}
