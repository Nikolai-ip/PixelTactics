using Infrastructure.GameSM;
using Infrastructure.GameSM.GameState;
using UnityEngine;

namespace Infrastructure.Bootstrapper
{
    public class GameBootstrapper : MonoBehaviour, ICoroutineRunner
    {
        private static GameStateMachineBuilder _gameStateMachineBuilder;

        private void Awake()
        {
            _gameStateMachineBuilder = new GameStateMachineBuilder(this);
            _gameStateMachineBuilder.StateMachine.Enter<BootstrapState>();
            DontDestroyOnLoad(this);
        }
    }
}