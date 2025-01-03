using System;
using System.Collections.Generic;
using GameCore;
using Infrastructure.Cmd;

namespace Assets.Scripts.Cmd
{
    public class PlayerActionHandler : ICommandProcessor
    {
        protected Dictionary<Type, ICommandHandler> _handlers;
        protected int actionPoints;

        protected int ActionPoints
        {
            get => actionPoints;
            set
            { 
                actionPoints = value;
                ActionPointsChanged?.Invoke(actionPoints);
            }
        }

        public event Action<int> ActionPointsChanged;
        protected Dictionary<Type, int> ActionPointMap;

        public PlayerActionHandler(Dictionary<Type, int> actionPointMap, Dictionary<Type, ICommandHandler> handlers = null)
        {
            ActionPointMap = actionPointMap;
            if (handlers == null)
                _handlers = new();
            else
                _handlers = handlers;
            ResetActionPoints();
        }
        public void RegisterHandler<TCommand>(ICommandHandler<TCommand> handler) where TCommand : ICommand
        {
            _handlers[typeof(TCommand)] = handler;

        }

        public bool Process<TCommand>(TCommand command) where TCommand : ICommand
        {
            if (_handlers.TryGetValue(command.GetType(), out ICommandHandler handler))
            {
                if (handler.TryHandle(command))
                {
                    ActionPoints -= ActionPointMap[command.GetType()];
                    return true;
                }
            }
            return false;
        }
        private void ResetActionPoints() => ActionPoints = GameConfig.ActionsAmount;
    }
}
