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


namespace Assets.Scripts.GameCore.Fabrics
{
    internal class PlayerFabric
    {
        public ServiceLocator GetPlayer(IEnumerable<Hero> Heroes)
        {
            var player = new ServiceLocator();
            player.Register<Deck>(new StandardDeck(Heroes));
            player.Register<Hand>(new StandardHand());
            player.Register<Dump>(new StandardDump());
            player.Register<GameField>(new GameField(GameConfig.FieldSizeX, GameConfig.FieldSizeY));
            return player;
        }
    }
}
