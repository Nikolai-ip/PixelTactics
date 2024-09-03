using GameCore; 

namespace Assets.Scripts.GameCore.InputActions
{
    public abstract class Input
    {
        public ActionType ActionType { get; }

        protected Input(ActionType actionType)
        {
            ActionType = actionType;
        }

    }
}
