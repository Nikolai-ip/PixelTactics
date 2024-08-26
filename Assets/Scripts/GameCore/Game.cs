using System;
using System.Collections.Generic;
using Assets.Scripts.GameCore.Fabrics;
using Assets.Scripts.GameCore.HeroModule;
using GameCore.Heros;
using GameCore.Decks;
using GameCore.Dumps;
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

            _stateMachine = new GameStateMachine(
                new Dictionary<Type, IState>()
                {
                    { typeof(Beginning), new Beginning() },
                    { typeof(FirstWave), new FirstWave() },
                    { typeof(GameCycle), new GameCycle() },
                });

            StartGameCycle();
        }

        private void StartGameCycle()
        {
            _stateMachine.EnterState<Beginning>();  
            _stateMachine.EnterState<FirstWave>();  
        }
    }

    public class Beginning : IState
    {
        private readonly List<ServiceLocator> _players;

        public void Enter()
        {
            for (int i = 0; i < _players.Count; i++)
            {
                var deck = _players[i].Get<Deck>();
                var hand = _players[i].Get<Hand>();

                for (int j = 0; j < GameConfig.BeginHandAmount; j++) 
                    hand.TryAddHero(deck.GetHero());
            }
        }

        public void Exit()
        {
            
        }

        public void HandleInput(Input input)
        {
            throw new NotImplementedException();
        }
    }

    public class GameCycle : IState
    {
        public void Enter()
        {
            throw new NotImplementedException();
        }

        public void Exit()
        {
            throw new NotImplementedException();
        }

        public void HandleInput(Input input)
        {
            throw new NotImplementedException();
        }
    }

    public class FirstWave : IState
    {
        public void Enter()
        {
            
        }

        public void Exit()
        {
            throw new NotImplementedException();
        }

        public void HandleInput(Input input)
        {
            throw new NotImplementedException();
        }
    }

    public class GameStateMachine
    {
        private readonly Dictionary<Type, IState> _states;
        private IState _currentState;

        public GameStateMachine(Dictionary<Type, IState> states)
        {
            _states = states;
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