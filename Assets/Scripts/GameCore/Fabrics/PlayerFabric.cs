using GameCore.Fields;
using GameCore.Cards;
using System.Collections.Generic;
using Assets.Scripts.GameCore.HeroModule;


namespace Assets.Scripts.GameCore.Fabrics
{
    internal class PlayerFabric
    {
        public ServiceContainer GetPlayer(IEnumerable<Hero> Heroes,GameField gameField)
        {
            var player = new ServiceContainer();
            player.Register<Deck>(new StandardDeck(Heroes));
            player.Register<Hand>(new StandardHand());
            player.Register<Dump>(new StandardDump());
            player.Register<GameField>(gameField);
            player.Register<PlayerStateMachine>(new PlayerStateMachine());
            return player;
        }
    }
}
