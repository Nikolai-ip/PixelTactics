
using Assets.Scripts.GameCore.GamePhases;
using GameCore;
using GameCore.Fields;
using System;
using System.Collections.Generic;
using Assets.Scripts.Cmd;

namespace Assets.Scripts.GameCore.Fabrics
{
    internal class TwoPlayersStandartRules : GameSMBuilder
    {
        public override TwoPlayersStandartRules InitStates(List<PlayerActionHandler> players)
        {
            GameStateMachine.InitStates(new Dictionary<Type, IState>()
                {
                    { typeof(GameCycle), new GameCycle().Init(GameStateMachine,players[0],players[1]) },
                }); 
            return this;
        }

        public override TwoPlayersStandartRules InitGameFields(List<GameField> gameFields)
        {
            return this;
        }
    }
}
