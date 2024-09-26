using System;
using System.Collections.Generic;
using Assets.Scripts.Cmd;
using GameCore.Commands;

namespace GameCore
{
    public static class GameConfig
    {
        public static readonly int FieldSizeX = 3;
        public static readonly int FieldSizeY = 3;
        public static readonly int PlayersAmount = 2;
        public static readonly int BeginHandAmount = 5;
        public static readonly int ActionsAmount = 2;

        public static readonly Dictionary<Type, int> ActionCost = new()
        {
            {typeof(HireHero), 1},
        };
    }
}