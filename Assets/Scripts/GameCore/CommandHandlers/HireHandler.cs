﻿using Assets.Scripts.Cmd;
using Assets.Scripts.GameCore.Commands;
using GameCore.Fields;
using Infrastructure.Cmd;

namespace GameCore.CommandHandlers
{
    public class HireHandler : ICommandHandler<HireHero>
    {
        private GameField _gameField;
        public HireHandler(GameField gameField)
        {
            _gameField = gameField;
        }

        public bool TryHandle(HireHero command)
        {
            var result = _gameField.TryHireHero(command.HireCoord, command.Hero);
            return result;
        }
    }
}
