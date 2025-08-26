using Infrastructure.Cmd;
using Infrastructure.Services;

namespace Presenter.Input
{
    public interface IInputHandler:IService
    {
        void OnCommand(ICommand command);
    }
}