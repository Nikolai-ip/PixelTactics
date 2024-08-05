using GameCore;
using UnityEngine;

public class GameBootstrapper : MonoBehaviour
{
    private Game _game;

    private void Start()
    {
        _game = new Game();
    }
}
