using Infrastructure.Services;
using Infrastructure.Services.ServiceLocator;

namespace Infrastructure.GameSM
{
    public class GameStateMachineBuilder
    {
        private readonly GameStateMachine _stateMachine;
        public GameStateMachine StateMachine => _stateMachine;
        public GameStateMachineBuilder(ICoroutineRunner coroutineRunner)
        {
            _stateMachine = new GameStateMachine(new SceneLoader(coroutineRunner), GameServices.Container);
        }
        
    }
}