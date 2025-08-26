using GameCore.Fields;
using GameCore.PlayerCmd;
using Infrastructure.Cmd;
using Infrastructure.Factory.GameEntity;

namespace GameCore
{
    public class Game : IModelCommandHandler
    {
        private readonly GameActionHandler _gameActionHandler;
        private readonly GameContext _gameContext;
        public Game(IPlayerFactory playerFactory, IActionHandlerFactory actionHandlerFactory)
        {
            var leftField = new GameField(GameConfig.FieldSizeX, GameConfig.FieldSizeY);
            var rightField = new GameField(GameConfig.FieldSizeX, GameConfig.FieldSizeY);
            var leftPlayer = playerFactory.GetPlayer(leftField);
            var rightPlayer = playerFactory.GetPlayer(rightField);
            var currentPlayer = leftPlayer;
            _gameContext = new GameContext(leftPlayer, rightPlayer, currentPlayer, leftField, rightField );
            _gameActionHandler = actionHandlerFactory.GetActionHandler(_gameContext);
        }
        public bool TryHandle(ICommand command)
        {
            var result = _gameActionHandler.Process(command);
            return result;
        }
    }

    public class GameContext
    {
        public Player LeftPlayer { get;}

        public Player RightPlayer { get; }

        public Player CurrentPlayer { get;}

        public GameField LeftField { get;}

        public GameField RightField { get; }
        public WaveType CurrentWaveType { get; private set; }

        public GameContext(Player leftPlayer, Player rightPlayer, Player currentPlayer, GameField leftField, GameField rightField)
        {
            LeftPlayer = leftPlayer;
            RightPlayer = rightPlayer;
            CurrentPlayer = currentPlayer;
            LeftField = leftField;
            RightField = rightField;
            CurrentWaveType = WaveType.Front;
        }
    }
}