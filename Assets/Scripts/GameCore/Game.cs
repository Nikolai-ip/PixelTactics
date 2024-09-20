using System;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.GameCore.Fabrics;
using Assets.Scripts.GameCore.GamePhases;
using Assets.Scripts.GameCore.HeroModule;
using Assets.Scripts.Cmd;
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
            var playerActionHandlerFabric = new PlayerActionHandlerFabric();
            var leftPlayer = playerFabric.GetPlayer(new List<Hero>(),  new GameField(GameConfig.FieldSizeX, GameConfig.FieldSizeY));
            var rightPlayer = playerFabric.GetPlayer(new List<Hero>(), new GameField(GameConfig.FieldSizeX, GameConfig.FieldSizeY));
            var leftPlayerActionHandler = playerActionHandlerFabric.Get(leftPlayer,rightPlayer);
            var rightPlayerActionHandler = playerActionHandlerFabric.Get(rightPlayer,leftPlayer);
            _stateMachine = new TwoPlayersStandartRules().InitStates(new List<PlayerActionHandler>(){leftPlayerActionHandler,rightPlayerActionHandler}).GetGameStateMachine;

            StartGameCycle();
        }

        private void StartGameCycle()
        {
            _stateMachine.ChangeState<GameCycle>();  
        }
    }

    public class GameStateMachine
    {
        private Dictionary<Type, IState> _states;
        private IState _currentState;

        #region InitSM
        public void InitStates(Dictionary<Type, IState> states)
        {
            _states = states;
            _currentState = _states.First().Value;
            _currentState.Enter();
        }

        #endregion
        public void ChangeState<T>()
        {
            var stateType = typeof(T);
            if (!_states.ContainsKey(stateType))
                return;

            if (_currentState != null)
                _currentState.Exit();
            _currentState = _states[stateType];
            _currentState.Enter();
        }
        public void HandleInput(ICommand command)
        {
            _currentState.HandleInput(command);
        }
    }
}