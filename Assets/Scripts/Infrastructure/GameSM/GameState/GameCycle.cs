using System.Collections.Generic;
using Assets.Scripts.Cmd;
using Assets.Scripts.GameCore;
using Assets.Scripts.GameCore.Fields;
using Assets.Scripts.GameCore.HeroModule;
using GameCore;
using GameCore.Commands;
using GameCore.Fields;
using Infrastructure.Cmd;
using Infrastructure.Factory.GameEntity;
using Infrastructure.Services;

namespace Infrastructure.GameSM.GameState
{
    public class GameCycle : IState
    {
        private readonly GameStateMachine _gameStateMachine;
        private GameStateMachine _game;
        public PlayerActionHandler LeftPlayerActionHandler { get; private set; }
        public PlayerActionHandler RightPlayerActionHandler { get; private set; }
        public PlayerActionHandler CurrentPlayer { get; private set; }
        public WaveType CurrentWaveType { get; private set; }
        private GameField _leftField, _rightField;
        private ServiceContainer _leftPlayer, _rightPlayer;
        public GameCycle(GameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
        }

        public void Enter()
        {
            _leftField = new GameField(GameConfig.FieldSizeX,GameConfig.FieldSizeY);
            _rightField = new GameField(GameConfig.FieldSizeX,GameConfig.FieldSizeY);
            var playerFabric = new PlayerFactory();
            var playerActionHandlerFabric = new PlayerActionHandlerFactory();
            _leftPlayer = playerFabric.GetPlayer(new List<Hero>(), _leftField);
            _rightPlayer = playerFabric.GetPlayer(new List<Hero>(), _rightField);
            LeftPlayerActionHandler = playerActionHandlerFabric.GetPlayerActionHandler(_leftPlayer,_rightPlayer);
            RightPlayerActionHandler= playerActionHandlerFabric.GetPlayerActionHandler(_rightPlayer,_leftPlayer);
            CurrentPlayer = LeftPlayerActionHandler;
            TryHandle(new HireHero(_leftField, new Coord(1, 2), new Hero("Assassin")));
        }

        public void Exit()
        {
        }
        

        public bool TryHandle(ICommand command)
        {
            var result = CurrentPlayer.Process(command);
            return result;
        }
    }
}
