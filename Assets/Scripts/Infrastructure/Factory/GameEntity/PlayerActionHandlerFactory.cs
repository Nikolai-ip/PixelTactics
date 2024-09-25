using Assets.Scripts.Cmd;
using GameCore;
using GameCore.CommandHandlers;
using GameCore.Fields;
using Infrastructure.Services;

namespace Infrastructure.Factory.GameEntity
{
    public class PlayerActionHandlerFactory
    {
        public virtual PlayerActionHandler Get(ServiceContainer player, ServiceContainer enemy)
        {
            var playerActionHandler = new PlayerActionHandler(GameConfig.ActionCost);
            playerActionHandler.RegisterHandler(new HireHandler(player.Get<GameField>()));
            return playerActionHandler;
        }
    }
}