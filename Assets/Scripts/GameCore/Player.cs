using GameCore.Fields;
using Infrastructure.Cmd;
using Infrastructure.Services;

namespace GameCore
{
    public class Player
    {
        private GameField _field;
        public GameField Field => _field;

        public PlayerServices Container => _container;

        private PlayerServices _container;

        public Player(GameField field, PlayerServices container)
        {
            _field = field;
            _container = container;
        }
    }
}