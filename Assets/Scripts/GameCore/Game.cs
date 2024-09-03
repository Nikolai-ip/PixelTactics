using System;
using System.Collections.Generic;
using Assets.Scripts.GameCore.Fabrics;
using Assets.Scripts.GameCore.GamePhases;
using Assets.Scripts.GameCore.HeroModule;
using GameCore.Decks;
using GameCore.Fields;
using GameCore.Hands;

namespace GameCore
{
    public class Game
    {
        private readonly GameStateMachine _stateMachine;
        private readonly ServiceLocator _firstPlayer;
        private readonly ServiceLocator _secondPlayer;
        private int _currentPlayerTurn = 0;
        public Game()
        {
            var playerFabric = new PlayerFabric();
            _firstPlayer = playerFabric.GetPlayer(new List<Hero>());
            _secondPlayer = playerFabric.GetPlayer(new List<Hero>());

            _stateMachine = new TwoPlayersStandartRules()
                .InitStates()
                .InitPlayers(new List<ServiceLocator> { _firstPlayer, _secondPlayer })
                .GetGameStateMachine;

            StartGameCycle();
        }

        private void StartGameCycle()
        {
            _stateMachine.EnterState<GameCycle>();  
        }
    }


    public class FirstWave : IState
    {
        public void Enter()
        {
            
        }

        public void Exit()
        {
        }

        public void HandleInput(Input input)
        {
        }
    }

    public class GameStateMachine
    {
        private Dictionary<Type, IState> _states;
        private IState _currentState;
        public ServiceLocator FirstPlayer { get; private set; }
        public ServiceLocator SecondPlayer { get; private set; }
        public GameField GameField { get; private set; }
        

        public void InitStates(Dictionary<Type, IState> states)
        {
            _states = states;
        }

        public void InitTwoPlayers(ServiceLocator firstPlayer, ServiceLocator secondPlayer)
        {
            FirstPlayer = firstPlayer;
            SecondPlayer = secondPlayer;
        }
        public void InitGameField(GameField gameField)
        {
            GameField = gameField;
        }
        
        
        public void EnterState<T>()
        {
            var stateType = typeof(T);
            if (!_states.ContainsKey(stateType))
                return;

            if (_currentState != null)
                _currentState.Exit();
            _currentState = _states[stateType];
            _currentState.Enter();
        }
    }
}