using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.GameCore.HeroModule;
using Assets.Scripts.GameCore.Fields;
using GameCore.Fields;
using Infrastructure;
using Infrastructure.Factories.GameEntities;

namespace GameCore
{
    public class Game
    {
        private readonly GameStateMachine _stateMachine;
        private int _currentPlayerTurn = 0;
        public GameStateMachine StateMachine => _stateMachine;
        public Game(ICoroutineRunner coroutineRunner)
        {
            var leftGameField = new GameField(GameConfig.FieldSizeX,GameConfig.FieldSizeY);
            leftGameField.TryHireHero(new Coord(2, 1), new Hero("Assassin"));
            var rightGameField = new GameField(GameConfig.FieldSizeX,GameConfig.FieldSizeY);
            var playerFabric = new PlayerFactory();
            var playerActionHandlerFabric = new PlayerActionHandlerFactory();
            var leftPlayer = playerFabric.Get(new List<Hero>(), leftGameField);
            var rightPlayer = playerFabric.Get(new List<Hero>(), rightGameField);
            var leftPlayerActionHandler = playerActionHandlerFabric.Get(leftPlayer,rightPlayer);
            var rightPlayerActionHandler = playerActionHandlerFabric.Get(rightPlayer,leftPlayer); 
            _stateMachine = new GameStateMachine(new SceneLoader(coroutineRunner));
        }
        
    }
}