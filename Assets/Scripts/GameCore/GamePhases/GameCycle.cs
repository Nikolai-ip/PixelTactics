using Assets.Scripts.GameCore.InputActions;
using GameCore;

namespace Assets.Scripts.GameCore.GamePhases
{
    public class GameCycle : IState
    {
        private GameStateMachine _game;       
        public void Enter()
        {
        }

        public void Exit()
        {
        }

        public IState Init(GameStateMachine game)
        {
            _game = game;
            return this;
        }
        public void HandleInput(Input input)
        {
            _game.CurrentPlayer.Get<PlayerStateMachine>().HandleInput(input);
        }
    }
}
