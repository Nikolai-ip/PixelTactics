﻿using System;
using System.Collections.Generic;
using Assets.Scripts.Cmd;
using Infrastructure;
using Infrastructure.GameSM.GameStates;

namespace GameCore
{
    public class GameStateMachine:ICommandHandler<ICommand>
    {
        private Dictionary<Type, IExitableState> _states;
        private IExitableState _currentState;
        public GameStateMachine(SceneLoader sceneLoader)
        {
            _states = new Dictionary<Type, IExitableState>()
            {
                {typeof(BootstrapState), new BootstrapState(this, sceneLoader)},
                {typeof(LoadLevelState), new LoadLevelState(this, sceneLoader)},
                {typeof(GameCycle), new GameCycle(this)},
            };
        }
        public void Enter<TState>() where TState: class, IState
        {
            var state = ChangeState<TState>();
            state.Enter();
        }
        public void Enter<TState, TPayLoad>(TPayLoad payLoad) where TState: class, IPayLoadedState<TPayLoad>
        {
            var state = ChangeState<TState>();
            state.Enter(payLoad);
        }
        private TState ChangeState<TState>() where TState : class, IExitableState
        {
            _currentState?.Exit();
            var state = GetState<TState>();
            _currentState = state;
            return state;
        }
        private TState GetState<TState>() where TState: class, IExitableState
        {
            return _states[typeof(TState)] as TState;
        }

        public bool TryHandle(ICommand command)
        {
            var result = _currentState.TryHandle(command);
            return result;
        }
    }
}