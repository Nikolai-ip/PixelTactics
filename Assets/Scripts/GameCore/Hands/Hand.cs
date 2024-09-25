using System.Collections.Generic;
using Assets.Scripts.GameCore.HeroModule;
using Infrastructure.Services;
using JetBrains.Annotations;

namespace GameCore.Cards
{
    public abstract class Hand : IService
    {
        protected List<Hero> Heroes;

        [CanBeNull] 
        public abstract Hero this[int i] { get; set; }
    
        public bool TryAddHero(Hero Hero)
        {
            if (Heroes.Contains(Hero))
                return false;
            
            Heroes.Add(Hero);
            return true;
        }
        
        public void MoveTo(Hand hand)
        {
            hand.Heroes = Heroes;
            Heroes = null;
        }
    }
}