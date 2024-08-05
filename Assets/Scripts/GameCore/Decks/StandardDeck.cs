using System.Collections.Generic;
using GameCore.Cards;

namespace GameCore.Decks
{
    class StandardDeck : Deck
    {
        public StandardDeck(LinkedList<Card> cards) : base(cards) { }

        public override void AddCard(Card card)
        {
            if (_cards.Contains(card))
                return;

            _cards.AddFirst(card);
        }

        public override Card GetCard()
        {
            Card card = _cards.First.Value;
            _cards.RemoveFirst();
            return card;
        }
    }
}