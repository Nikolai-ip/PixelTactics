using System.Collections.Generic;
using GameCore;
using GameCore.Fields;
using Infrastructure.Services;

namespace Infrastructure.Factory.GameEntity
{
    public interface IPlayerFactory:IService
    {
        Player GetPlayer(GameField gameField);
    }
}