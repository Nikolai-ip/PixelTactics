using GameCore.Commands;
using GameCore.Fields;
using GameCore.HeroModule;
using Infrastructure.Cmd;

namespace GameCore.CommandHandlers
{
    internal class SelectHandler : ICommandHandler<SelectHero>
    {
        private GameContext _gameContext;
        public SelectHandler(GameContext gameContext)
        {
            _gameContext = gameContext;
        }

        public bool TryHandle(SelectHero command)
        {
            bool result = _gameContext.CurrentPlayer.Field[command.HeroCoord.X, command.HeroCoord.Y].TryGetHero(out Hero hero);
            return result;
        }

        public bool TryHandle(ICommand command)
        {
            return TryHandle(command as SelectHero);
        }
    }
}
