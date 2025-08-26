using GameCore.Commands;
using GameCore.Fields;
using Infrastructure.Cmd;

namespace GameCore.CommandHandlers
{
    public class HireHandler : ICommandHandler<HireHero>
    {
        private GameContext _gameContext;
        public HireHandler(GameContext gameContext)
        {
            _gameContext = gameContext;
        }

        public bool TryHandle(HireHero command)
        {
            var result = _gameContext.CurrentPlayer.Field.TryHireHero(command.HireCoord, command.Hero);
            return result;
        }

        public bool TryHandle(ICommand command)
        {
            return TryHandle(command as HireHero);
        }
    }
}
