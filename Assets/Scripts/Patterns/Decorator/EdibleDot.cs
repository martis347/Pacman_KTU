using System;
using Assets.Scripts.Patterns.Singleton;
using UnityEngine;

namespace Assets.Scripts.Patterns.Decorator
{
    public class EdibleDot: EdibleElement
    {
        public void Start()
        {
            
        }

        public void Update()
        {
            
        }

        public void OnTriggerEnter(Collider collider)
        {
            if (collider.gameObject.name == "Pacman!")
            {
                ScoreboardSingleton.Scoreboard.AddPoints(Points);
                Destroy(gameObject);
            }
        }
    }
}