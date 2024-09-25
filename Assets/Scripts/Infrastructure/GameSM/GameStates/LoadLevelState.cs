using Assets.Scripts.Cmd;
using GameCore;
using Infrastructure.Factories;

namespace Infrastructure.GameSM.GameStates
{
    public class LoadLevelState : IPayLoadedState<string>
    {
        private readonly GameStateMachine _gameSm;
        private readonly SceneLoader _sceneLoader;
        private readonly IGameFactory _gameFactory;

        public LoadLevelState(GameStateMachine gameStateMachine, SceneLoader sceneLoader)
        {
            _gameSm = gameStateMachine;
            _sceneLoader = sceneLoader;
        }

        public bool TryHandle(ICommand command)
        {
            return false;
        }

        public void Enter(string sceneName)
        {
            _sceneLoader.Load(sceneName, OnLoaded);
        }
        public void Exit()
        {
        }
        private void OnLoaded()
        {
            _gameFactory.CreateHud();
        }
    }
}