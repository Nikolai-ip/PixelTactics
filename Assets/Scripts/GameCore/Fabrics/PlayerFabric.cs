using GameCore.Decks;
using GameCore.Dumps;
using GameCore.Fields;
using GameCore.Hands;
using GameCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.GameCore.HeroModule;
using Assets.Scripts.GameCore.GamePhases.WavePhases;


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
