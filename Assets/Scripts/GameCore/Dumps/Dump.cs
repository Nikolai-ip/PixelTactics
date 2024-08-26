using System.Collections.Generic;
using GameCore.Cards;
using JetBrains.Annotations;

namespace GameCore.Dumps
{
    public abstract class Dump : IService
    {
        protected List<Card> _cards;
    
        [CanBeNull] 
        public abstract Card this[int i] { get; set; }
    
        public bool TryAdd(Card card)
        {
            if (_cards.Contains(card))
                return false;
            
            _cards.Add(card);
            return true;
        }
        
        public void MoveTo(Dump dump)
        {
            dump._cards = _cards;
            _cards = null;
        }
    }
}