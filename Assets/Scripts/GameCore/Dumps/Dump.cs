﻿using System.Collections.Generic;
using Assets.Scripts.GameCore.HeroModule;
using JetBrains.Annotations;

namespace GameCore.Dumps
{
    public abstract class Dump : IService
    {
        protected List<Hero> Heroes;
    
        [CanBeNull] 
        public abstract Hero this[int i] { get; set; }
    
        public bool TryAdd(Hero Hero)
        {
            if (Heroes.Contains(Hero))
                return false;
            
            Heroes.Add(Hero);
            return true;
        }
        
        public void MoveTo(Dump dump)
        {
            dump.Heroes = Heroes;
            Heroes = null;
        }
    }
}