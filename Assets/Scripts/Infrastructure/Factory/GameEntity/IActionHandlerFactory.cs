using GameCore;
using GameCore.PlayerCmd;
using Infrastructure.Services;

namespace Infrastructure.Factory.GameEntity
{
    public interface IActionHandlerFactory:IService
    {
        GameActionHandler GetActionHandler(GameContext gameContext);
    }
}