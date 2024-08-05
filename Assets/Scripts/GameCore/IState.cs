using UnityEngine;

namespace GameCore
{
    public interface IState
    {
        void Enter();
        void Exit();
        void HandleInput(Input input);
    }

    public class Input
    {
        public Vector2Int PosFrom;
        public Vector2Int PosTo;
        public ActionType Action;
    }

    public enum ActionType
    {
        TakeCardFromDeck,
        HireHero,
        
    }
    
    
    // Attack,
    // Spell,
    // Order,
}