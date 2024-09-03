using GameCore;
using UnityEngine;

public class GameBootstrapper
{
    private static Game _game;

    [RuntimeInitializeOnLoadMethod]
    private static void InitGame()
    {
        _game = new Game();
    }
}
