using System.Collections.Generic;
using GameCore.Cards;
using JetBrains.Annotations;

namespace GameCore.Hands
{
    public abstract class Hand : IService
    {
        protected List<Card> _cards;

        [CanBeNull] 
        public abstract Card this[int i] { get; set; }
    
        public void AddCard(Card card)
        {
            if (_cards.Contains(card))
                return;
            
            _cards.Add(card);
        }
        
        public void MoveTo(Hand hand)
        {
            hand._cards = _cards;
            _cards = null;
        }
    }
}