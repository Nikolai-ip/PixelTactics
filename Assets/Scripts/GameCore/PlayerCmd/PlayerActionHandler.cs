using System;
using System.Collections.Generic;

namespace Assets.Scripts.Cmd
{
    public class PlayerActionHandler : ICommandProcessor
    {
        protected Dictionary<Type, object> _handlers;
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

        public PlayerActionHandler(Dictionary<Type, int> actionPointMap, Dictionary<Type, object> handlers = null)
        {
            ActionPointMap = actionPointMap;
            if (handlers == null)
                _handlers = new();
            else
                _handlers = handlers;
        }
        public void RegisterHandler<TCommand>(ICommandHandler<TCommand> handler) where TCommand : ICommand
        {
            _handlers[typeof(TCommand)] = handler;

        }

        public bool Process<TCommand>(TCommand command) where TCommand : ICommand
        {
            if (_handlers.TryGetValue(typeof(ICommand), out var handlerObj))
            {
                var handler = (ICommandHandler<ICommand>)handlerObj;
                var result = handler.TryHandle(command);
                if (result)
                {
                    ActionPoints -= ActionPointMap[typeof(TCommand)];
                }
                return result;
            }
            return false;
        }
    }
}
