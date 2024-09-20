using Assets.Scripts.Cmd;
using GameCore;

namespace Assets.Scripts.GameCore.GamePhases
{
    public class GameCycle : IState
    {
        private GameStateMachine _game;
        public PlayerActionHandler LeftPlayer { get; private set; }
        public PlayerActionHandler RightPlayer { get; private set; }
        public PlayerActionHandler CurrentPlayer { get; private set; }
        public WaveType CurrentWaveType { get; private set; }
        public void Enter()
        {
        }

        public void Exit()
        {
        }

        public IState Init(GameStateMachine game, PlayerActionHandler leftPlayer, PlayerActionHandler rightPlayer)
        {
            _game = game;
            LeftPlayer = leftPlayer;
            RightPlayer = rightPlayer;
            return this;
        }
        public void HandleInput(ICommand input)
        {
            CurrentPlayer.Process(input);
        }
    }
}
