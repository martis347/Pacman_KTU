using System;
using System.IO;
using Assets.Scripts.Components;

namespace Assets.Scripts.Patterns.Proxy
{
    public class GameLogger: IGameLogger
    {
        private StreamWriter streamWriter;
        private GameConsole gameConsole;

        public override void LogMessage(string message)
        {
            streamWriter.WriteLine(FormatMessage(message));
            gameConsole.WriteToConsole(FormatMessage(message));
        }

        public StreamWriter StreamWriter
        {
            set { streamWriter = value; }
        }

        public GameConsole GameConsole
        {
            set { gameConsole = value; }
        }

        private string FormatMessage(string message)
        {
            message = String.Format("[{0:yyyy-MM-dd H:mm:ss}]\t {1}", DateTime.Now, message);

            return message;
        }
    }
}