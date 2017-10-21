using System;
using System.Linq;
using ModestTree;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Components
{
    public class GameConsole: MonoBehaviour
    {
        public Text TextComponent;

        public void WriteToConsole(string message)
        {
            var consoleText = TextComponent.text;

            var consoleLines = consoleText.Split(Environment.NewLine.ToCharArray())
                .Except("")
                .Reverse()
                .Take(11)
                .Reverse()
                .ToList();

            consoleLines.Add(message);

            TextComponent.text = String.Join(Environment.NewLine, consoleLines.ToArray());
        }
    }
}