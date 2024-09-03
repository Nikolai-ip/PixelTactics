﻿using GameCore.Decks;
using GameCore;
using System.Collections.Generic;
using GameCore.Hands;
using Assets.Scripts.GameCore.InputActions;

namespace Assets.Scripts.GameCore.GamePhases
{ 
    public class Beginning : IState
    {
        private readonly List<ServiceContainer> _players;

        public void Enter()
        {
            for (int i = 0; i < _players.Count; i++)
            {
                var deck = _players[i].Get<Deck>();
                var hand = _players[i].Get<Hand>();

                for (int j = 0; j < GameConfig.BeginHandAmount; j++)
                    hand.TryAddHero(deck.GetHero());
            }
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