using Assets.Scripts.GameCore.InputActions;

namespace GameCore
{
    public interface IState
    {
        void Enter();
        void Exit();
        void HandleInput(Input input);
    }

    public enum ActionType
    {
        TakeCardFromDeck,
        HireHero,
        MoveHero,

        
    }
}