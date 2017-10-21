using System;
using Assets.Scripts.Patterns.Proxy;
using Assets.Scripts.Patterns.Singleton;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Patterns.Decorator
{
    public class EdibleDot: EdibleElement
    {
        private IGameLogger logger;
        public void Start()
        {
            logger = new ProxyLogger();
        }

        public void Update()
        {
            
        }

        public void OnTriggerEnter(Collider collider)
        {
            if (collider.gameObject.name == "Pacman!")
            {
                ScoreboardSingleton.Scoreboard.AddPoints(Points);
                logger.LogMessage(String.Format("Pacman collected {0} points!", Points));

                Destroy(gameObject);
            }
        }
    }
}