using Assets.Scripts.GameCore.HeroModule;
using System.Collections.Generic;

namespace GameCore.Decks
{
    class StandardDeck : Deck
    {
        public StandardDeck(IEnumerable<Hero> Heros):base(new LinkedList<Hero>(Heros))
        {}

        public override void AddHero(Hero Hero)
        {
            if (_Heros.Contains(Hero))
                return;

            _Heros.AddFirst(Hero);
        }

        public override Hero GetHero()
        {
            Hero Hero = _Heros.First.Value;
            _Heros.RemoveFirst();
            return Hero;
        }
    }
}