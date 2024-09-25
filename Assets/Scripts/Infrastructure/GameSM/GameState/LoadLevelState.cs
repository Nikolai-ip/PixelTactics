using Assets.Scripts.Cmd;
using GameCore;
using Infrastructure.Factory;
using Infrastructure.Services;

namespace Infrastructure.GameSM.GameState
{
    public class LoadLevelState : IPayLoadedState<string>
    {
        private readonly GameStateMachine _gameSm;
        private readonly SceneLoader _sceneLoader;
        private readonly IGameFactory _gameFactory;

        public LoadLevelState(GameStateMachine gameStateMachine, SceneLoader sceneLoader,IGameFactory gameFactory)
        {
            _gameSm = gameStateMachine;
            _sceneLoader = sceneLoader;
            _gameFactory = gameFactory;
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
            _gameSm.Enter<GameCycle>();
        }
    }
}