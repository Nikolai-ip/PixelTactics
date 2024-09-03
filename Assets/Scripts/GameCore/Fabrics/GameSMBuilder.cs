using Assets.Scripts.GameCore.GamePhases;
using GameCore;
using System.Collections.Generic;

namespace Assets.Scripts.GameCore.Fabrics
{
    internal abstract class GameSMBuilder
    {
        protected GameStateMachine GameStateMachine;
        public GameStateMachine GetGameStateMachine => GameStateMachine;
        public GameSMBuilder()
        {
            GameStateMachine = new GameStateMachine();
        }
        public abstract TwoPlayersStandartRules InitStates();

        public abstract TwoPlayersStandartRules InitPlayers(List<ServiceLocator> players);
    }
}
