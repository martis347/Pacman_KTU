using System.IO;
using Assets.Scripts.Components;
using UnityEngine;

namespace Assets.Scripts.Patterns.Proxy
{
    public class ProxyLogger: IGameLogger
    {
        private GameLogger gameLogger;
        private GameConsole gameConsole;
        private readonly object padlock = new object();

        public override void LogMessage(string message)
        {
            lock (padlock)
            {
                Initialize();
                using (var sw = new StreamWriter("GameLog.txt", true))
                {
                    gameLogger.StreamWriter = sw;
                    gameLogger.LogMessage(message);
                }
            }
        }

        private void Initialize()
        {
            if (gameLogger == null)
            {
                gameLogger = new GameLogger();
            }
            if (gameConsole == null)
            {
                gameConsole = GameObject.Find("GameConsole").GetComponent<GameConsole>();
                gameLogger.GameConsole = gameConsole;
            }
        }
    }
}