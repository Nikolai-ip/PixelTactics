using System;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.GameCore.Fabrics;
using Assets.Scripts.GameCore.GamePhases;
using Assets.Scripts.GameCore.HeroModule;
using Assets.Scripts.GameCore.InputActions;
using GameCore.Fields;

namespace GameCore
{
    public class Game
    {
        private readonly GameStateMachine _stateMachine;
        private int _currentPlayerTurn = 0;
        public Game()
        {
            var playerFabric = new PlayerFabric();
            var leftField = new GameField(GameConfig.FieldSizeX, GameConfig.FieldSizeY);
            var leftPlayer = playerFabric.GetPlayer(new List<Hero>(), leftField);
            var rightField = new GameField(GameConfig.FieldSizeX, GameConfig.FieldSizeY);
            var rightPlayer = playerFabric.GetPlayer(new List<Hero>(), rightField);

            _stateMachine = new TwoPlayersStandartRules()
                .InitStates()
                .InitPlayers(new List<ServiceContainer> { leftPlayer, rightPlayer })
                .InitGameFields(new List<GameField> { leftField, rightField })
                .GetGameStateMachine;

            StartGameCycle();
        }

        private void StartGameCycle()
        {
            _stateMachine.EnterState<GameCycle>();  
        }
    }

    public class GameStateMachine
    {
        private Dictionary<Type, IState> _states;
        private IState _currentState;
        public ServiceContainer LeftPlayer { get; private set; }
        public ServiceContainer RightPlayer { get; private set; }
        public GameField RightGameField { get; private set; }
        public GameField LeftGameField { get; private set; }

        public ServiceContainer CurrentPlayer { get; private set; }

        public void InitStates(Dictionary<Type, IState> states)
        {
            _states = states;
            _currentState = _states.First().Value;
            _currentState.Enter();
        }

        public void InitTwoPlayers(ServiceContainer leftPlayer, ServiceContainer rightPlayer, ServiceContainer currentPlayer)
        {
            LeftPlayer = leftPlayer;
            RightPlayer = rightPlayer;
            CurrentPlayer = currentPlayer;
        }
        public void InitGameFields(GameField leftField,GameField rightField)
        {
            RightGameField = rightField;
            LeftGameField = leftField;
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
        public void HandleInput(Input input)
        {
            _currentState.HandleInput(input);
        }
    }
}