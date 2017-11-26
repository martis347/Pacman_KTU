using System;
using Assets.Scripts.Patterns.Proxy;
using Assets.Scripts.Patterns.Singleton;
using UnityEngine;
using Assets.Scripts.Patterns.Visitor;

namespace Assets.Scripts.Patterns.Decorator
{
    public class EdibleDot:  EdibleElement, IVisitable
    {
        public IGameLogger logger;

        public void Start()
        {
            logger = new ProxyLogger();
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

        public void OnPacmanMove()
        {
            //TODO add smth
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}