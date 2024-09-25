using Infrastructure.AssetManagement;
using UnityEngine;

namespace Infrastructure.Factory
{

    public class GameFactory : IGameFactory
    {
        private readonly IAssetProvider _assetProvider;

        public GameFactory(IAssetProvider assetProvider)
        {
            _assetProvider = assetProvider;
        }

        public void CreateHud()
        {
            var window = _assetProvider.Instantiate(AssetPath.PrefabWindow, at:Vector3.zero);
            window.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceCamera;
            window.GetComponent<Canvas>().worldCamera = Camera.main;
        }
    }
}