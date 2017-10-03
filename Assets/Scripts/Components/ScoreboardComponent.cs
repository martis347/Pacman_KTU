using System;
using Assets.Scripts.Patterns.Singleton;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Components
{
    public class ScoreboardComponent: MonoBehaviour
    {
        public void Start()
        {
            
        }

        public void FixedUpdate()
        {
            var score = ScoreboardSingleton.Scoreboard.GetScore();

            var textOComponent = gameObject.GetComponent<Text>();

            textOComponent.text = String.Format("Collected Points: {0}\r\nNumber of Deaths: {1}", score.PointsScored, score.PacmanDeaths);
        }
    }
}