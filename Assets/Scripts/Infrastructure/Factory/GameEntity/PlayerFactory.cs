using System.Collections.Generic;
using GameCore;
using GameCore.Decks;
using GameCore.Dumps;
using GameCore.Fields;
using GameCore.Hands;
using GameCore.HeroModule;
using Infrastructure.Services;

namespace Infrastructure.Factory.GameEntity
{
    public class PlayerFactory : IPlayerFactory
    {
        private IEnumerable<Hero> _heroes;
        public PlayerFactory(IEnumerable<Hero> heroes)
        {
            _heroes = heroes;
        }

        public Player GetPlayer(GameField gameField)
        {
            var serviceContainer = new PlayerServices();
            serviceContainer.Register<Deck>(new StandardDeck(_heroes));
            serviceContainer.Register<Hand>(new StandardHand());
            serviceContainer.Register<Dump>(new StandardDump());
            serviceContainer.Register<GameField>(gameField);
            var player = new Player(gameField, serviceContainer);
            return player;
        }
    }
}
