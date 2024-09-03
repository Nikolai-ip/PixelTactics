
using Assets.Scripts.GameCore.GamePhases;
using GameCore;
using GameCore.Fields;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.GameCore.Fabrics
{
    internal class TwoPlayersStandartRules : GameSMBuilder
    {
        public override TwoPlayersStandartRules InitStates()
        {
            GameStateMachine.InitStates(new Dictionary<Type, IState>()
                {
                    //{ typeof(Beginning), new Beginning().Init(GameStateMachine) },
                    //{ typeof(FirstWave), new FirstWave() },
                    { typeof(GameCycle), new GameCycle().Init(GameStateMachine) },
                });
            return this;
        }
        public override TwoPlayersStandartRules InitPlayers(List<ServiceContainer> players)
        {
            int randomPlayerIndex = new Random().Next(players.Count - 1);
            GameStateMachine.InitTwoPlayers(players[0], players[1], players[randomPlayerIndex]);
            return this;
        }

        public override TwoPlayersStandartRules InitGameFields(List<GameField> gameFields)
        {
            GameStateMachine.InitGameFields(gameFields[0], gameFields[1]);
            return this;
        }
    }
}
