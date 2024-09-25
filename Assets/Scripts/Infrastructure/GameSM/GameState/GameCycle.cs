using Assets.Scripts.Cmd;
using Assets.Scripts.GameCore;
using GameCore;

namespace Infrastructure.GameSM.GameState
{
    public class GameCycle : IState
    {
        private readonly GameStateMachine _gameStateMachine;
        private GameStateMachine _game;
        public PlayerActionHandler LeftPlayer { get; private set; }
        public PlayerActionHandler RightPlayer { get; private set; }
        public PlayerActionHandler CurrentPlayer { get; private set; }
        public WaveType CurrentWaveType { get; private set; }
        public GameCycle(GameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
        }

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

        public bool TryHandle(ICommand command)
        {
            var result = CurrentPlayer.Process(command);
            return result;
        }
    }
}
