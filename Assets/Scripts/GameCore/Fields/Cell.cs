using Assets.Scripts.GameCore.HeroModule;

namespace GameCore.Fields
{
    public class Cell
    {
        private Hero _hero;
        public void HireHero(Hero hero)
        {
            _hero = hero;   
        }
        public bool TryGetHero(out Hero hero)
        {
            hero = _hero;
            if (hero == null)
                return false;
            return true;
        }

    }
}
