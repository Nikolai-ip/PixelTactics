using Infrastructure.Services;

namespace Infrastructure.Factory
{
    public interface IUnityViewFactory:IService
    {
        void CreateView();
    }
}