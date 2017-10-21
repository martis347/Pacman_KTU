using Assets.Scripts.Patterns.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Patterns.Iterator
{
    class Client
    {
        public void UseIterator()
        {
            ConcreteAggregate aggr = new ConcreteAggregate();
            var edibleGameObjects = GameObject.FindGameObjectsWithTag("Edible");
            var edibles = edibleGameObjects.Select(e => e.GetComponent<EdibleDot>()).ToList();

            aggr.AddRange(edibles);

            Iterator iterator = aggr.CreateIterator();
            var timer = new System.Threading.Timer(
                e => MyMethod(iterator),
                null,
                TimeSpan.Zero,
                TimeSpan.FromSeconds(1));
        }

        public void MyMethod(Iterator iterator)
        {
            if (iterator.Next())
            {
                Debug.Log("Testeris");
                EdibleDot item = (EdibleDot)iterator.Current;
                item.Points = 50;
                var renderer = item.GetComponent<Renderer>();
                renderer.material = Resources.Load<Material>("Black");

            }
        }
    }
}
