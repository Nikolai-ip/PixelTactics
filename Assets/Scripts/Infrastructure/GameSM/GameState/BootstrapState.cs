using Assets.Scripts.Cmd;
using Controllers.Input;
using GameCore;
using Infrastructure.AssetManagement;
using Infrastructure.Factory;
using Infrastructure.Services;
using Infrastructure.Services.ServiceLocator;

namespace Infrastructure.GameSM.GameState
{
    public class BootstrapState:IState
    {
        private const string InitialScene  = "Initial";
        private readonly GameStateMachine _gameSm;
        private readonly SceneLoader _sceneLoader;
        private GameServices _services;

        public BootstrapState(GameStateMachine gameSm,SceneLoader sceneLoader, GameServices gameServices)
        {
            _gameSm = gameSm;
            _sceneLoader = sceneLoader;
            _services = gameServices;
            RegisterServices();
        }
        public bool TryHandle(ICommand command)
        {
            return false;
        }

        public void Enter()
        {
            _sceneLoader.Load(InitialScene, EnterLoadLevel);
        }

        private void EnterLoadLevel()
        {
            _gameSm.Enter<LoadLevelState, string>("Main");
        }

        private void RegisterServices()
        {
            _services.RegisterSingle<IAssetProvider>(new AssetProvider());
            _services.RegisterSingle<IInputHandler>(new MouseInputHandler());
            _services.RegisterSingle<IGameFactory>(new GameFactory(_services.Single<IAssetProvider>()));
        }

        public void Exit()
        {
        }
    }
}