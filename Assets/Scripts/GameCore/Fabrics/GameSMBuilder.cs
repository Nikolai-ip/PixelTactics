using GameCore;
using GameCore.Fields;
using System.Collections.Generic;
using Assets.Scripts.Cmd;

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
        public abstract TwoPlayersStandartRules InitStates(List<PlayerActionHandler> players);
        public abstract TwoPlayersStandartRules InitGameFields(List<GameField> gameFields);

    }
}
