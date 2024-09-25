using Assets.Scripts.Cmd;
using GameCore;
using UnityEngine;

namespace Infrastructure.GameSM.GameStates
{
    public class BootstrapState:IState
    {
        private const string Initial = "Initial";
        private readonly GameStateMachine _gameSm;
        private readonly SceneLoader _sceneLoader;

        public BootstrapState(GameStateMachine gameSm,SceneLoader sceneLoader)
        {
            _gameSm = gameSm;
            _sceneLoader = sceneLoader;
        }
        public bool TryHandle(ICommand command)
        {
            return false;
        }

        public void Enter()
        {
            RegisterServices();
            Debug.Log("!");
            _sceneLoader.Load(Initial, EnterLoadLevel);
        }

        private void EnterLoadLevel()
        {
            _gameSm.Enter<LoadLevelState, string>("Main");
        }

        private void RegisterServices()
        {
        }

        public void Exit()
        {
        }
    }
}