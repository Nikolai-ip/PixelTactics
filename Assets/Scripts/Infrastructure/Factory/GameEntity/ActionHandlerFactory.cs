using GameCore;
using GameCore.CommandHandlers;
using GameCore.Fields;
using GameCore.PlayerCmd;
using Infrastructure.Services;

namespace Infrastructure.Factory.GameEntity
{
    public class ActionHandlerFactory : IActionHandlerFactory
    {
        public virtual GameActionHandler GetActionHandler(GameContext gameContext)
        {
            var playerActionHandler = new GameActionHandler(GameConfig.ActionCost);
            playerActionHandler.RegisterHandler(new HireHandler(gameContext));
            playerActionHandler.RegisterHandler(new SelectHandler(gameContext));
            return playerActionHandler;
        }
    }
}