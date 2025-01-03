using Assets.Scripts.Cmd;
using Assets.Scripts.GameCore.HeroModule;
using GameCore.Commands;
using GameCore.Fields;
using Infrastructure.Cmd;

namespace GameCore.CommandHandlers
{
    internal class SelectHandler : ICommandHandler<SelectHero>
    {
        private GameField _gameField;
        public SelectHandler(GameField gameField)
        {
            _gameField = gameField;
        }

        public bool TryHandle(SelectHero command)
        {
            if(_gameField[command.HeroCoord.X, command.HeroCoord.Y].TryGetHero(out Hero hero))
            {
                return true;
            }
            return false;
        }

        public bool TryHandle(ICommand command)
        {
            return TryHandle(command as SelectHero);
        }
    }
}
