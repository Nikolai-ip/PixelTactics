using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.GameCore.HeroModule;
using Assets.Scripts.GameCore.Fields;
using GameCore.Fields;
using Infrastructure;
using Infrastructure.Factory.GameEntity;
using Infrastructure.Services;
using Infrastructure.Services.ServiceLocator;

namespace GameCore
{
    public class Game
    {
        private readonly GameStateMachine _stateMachine;
        private int _currentPlayerTurn = 0;
        public GameStateMachine StateMachine => _stateMachine;
        public Game(ICoroutineRunner coroutineRunner)
        {
            _stateMachine = new GameStateMachine(new SceneLoader(coroutineRunner), GameServices.Container);
        }
        
    }
}