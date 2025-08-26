using GameCore;
using Infrastructure.Factory;
using Infrastructure.Services;
using Infrastructure.Services.ServiceLocator;

namespace Infrastructure.GameSM.GameState
{
    public class LoadLevelState : IPayLoadedState<string>, IState
    {
        private readonly GameStateMachine _gameSm;
        private readonly SceneLoader _sceneLoader;
        private readonly IUnityViewFactory _unityViewFactory;
        private readonly GameServices _serviceContainer;

        public LoadLevelState(GameStateMachine gameStateMachine, SceneLoader sceneLoader,IUnityViewFactory unityViewFactory, GameServices serviceContainer)
        {
            _gameSm = gameStateMachine;
            _sceneLoader = sceneLoader;
            _unityViewFactory = unityViewFactory;
            _serviceContainer = serviceContainer;
        }
        public void Enter(string sceneName)
        {
            _sceneLoader.Load(sceneName, OnLoaded);
        }
        public void Exit()
        {
        }

        public void Enter()
        {
            OnLoaded();
        }

        private void OnLoaded()
        {
            _unityViewFactory.CreateView();
            _gameSm.Enter<GameCycle, GameServices>(_serviceContainer);
        }
    }
}