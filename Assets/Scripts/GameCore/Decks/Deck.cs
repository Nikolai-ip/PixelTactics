using System.Collections.Generic;
using Assets.Scripts.GameCore.HeroModule;

namespace GameCore.Cards
{
    public abstract class Deck : IService
    {
        protected LinkedList<Hero> _Heros;
        
        public Deck(LinkedList<Hero> Heros)
        {
            _Heros = Heros;
        }
        public abstract void AddHero(Hero Hero);
        public abstract Hero GetHero();
        
        public void MoveTo(Deck deck)
        {
            deck._Heros = _Heros;
            _Heros = null;
        }
    }
}