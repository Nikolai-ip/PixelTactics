using Controllers.Input;
using Infrastructure.AssetManagement;
using Infrastructure.Services.ServiceLocator;
using UnityEngine;
using Views;

namespace Infrastructure.Factory
{

    public class UnityViewFactory : IUnityViewFactory
    {
        private readonly IAssetProvider _assetProvider;
        private readonly IInputHandler _inputHandler;

        public UnityViewFactory(IAssetProvider assetProvider, IInputHandler inputHandler)
        {
            _assetProvider = assetProvider;
            _inputHandler = inputHandler;
        }


        private void CreateHud()
        {
            var window = _assetProvider.Instantiate(AssetPath.PrefabWindow, at:Vector3.zero);
            window.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceCamera;
            window.GetComponent<Canvas>().worldCamera = Camera.main;
        }

        public void CreateView()
        {
        //    CreateHud();
            var uiHeroSelect = _assetProvider.Instantiate<UIHeroSelector>(AssetPath.PrefabUIHeroSelector);
            uiHeroSelect.Init(_inputHandler);
        }
        
    }
}