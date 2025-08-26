using System.Collections.Generic;
using GameCore;
using GameCore.Commands;
using GameCore.Fields;
using Infrastructure.Cmd;
using Infrastructure.Factory.GameEntity;
using Infrastructure.Services;
using Infrastructure.Services.ServiceLocator;

namespace Infrastructure.GameSM.GameState
{
    public class GameCycle : IPayLoadedState<GameServices>
    {
        private readonly GameStateMachine _gameStateMachine;
        private Game _game;
        private GameServices _services;

        public GameCycle(GameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
        }
        
        public void Enter(GameServices services)
        {
            _services = services;
            var playerFactory = _services.Single<IPlayerFactory>();
            IActionHandlerFactory actionHandler = _services.Single<IActionHandlerFactory>();
            _game = new Game(playerFactory, actionHandler);
        }

        public void Exit()
        {
        }
        
    }
}
