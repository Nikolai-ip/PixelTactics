using Assets.Scripts.Cmd;
using GameCore;
using Infrastructure.Factory;
using Infrastructure.Services;

namespace Infrastructure.GameSM.GameState
{
    public class LoadLevelState : IPayLoadedState<string>, IState
    {
        private readonly GameStateMachine _gameSm;
        private readonly SceneLoader _sceneLoader;
        private readonly IUnityViewFactory _unityViewFactory;

        public LoadLevelState(GameStateMachine gameStateMachine, SceneLoader sceneLoader,IUnityViewFactory unityViewFactory)
        {
            _gameSm = gameStateMachine;
            _sceneLoader = sceneLoader;
            _unityViewFactory = unityViewFactory;
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
            _gameSm.Enter<GameCycle>();
        }
    }
}