﻿using Assets.Scripts.GameCore.HeroModule;

namespace GameCore.Cards
{
    class StandardDump : Dump
    {
        public override Hero this[int i]
        {
            get => Heroes[i];
            set => Heroes[i] = value;
        }
    }
}