using GameCore;

namespace Assets.Scripts.GameCore.GamePhases
{
    public class GameCycle : IState
    {
        public void Enter()
        {
        }

        public void Exit()
        {
        }
        public IState Init(GameStateMachine game)
        {
            return this;
        }

        public void HandleInput(Input input)
        {
        }
    }
}
