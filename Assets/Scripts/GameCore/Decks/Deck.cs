using System.Collections.Generic;
using GameCore.Cards;

namespace GameCore.Decks
{
    public abstract class Deck : IService
    {
        protected LinkedList<Card> _cards;
        
        public Deck(LinkedList<Card> cards)
        {
            _cards = cards;
        }
        public abstract void AddCard(Card card);
        public abstract Card GetCard();
        
        public void MoveTo(Deck deck)
        {
            deck._cards = _cards;
            _cards = null;
        }
    }
}