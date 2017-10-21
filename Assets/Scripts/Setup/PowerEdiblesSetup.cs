using Assets.Scripts.Patterns.Decorator;
using Assets.Scripts.Patterns.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Setup
{
    class PowerEdiblesSetup : MonoBehaviour
    {
        private Iterator iterator;
    
        public void Start()
        {
            /*ConcreteAggregate aggr = new ConcreteAggregate();
            var edibleGameObjects = GameObject.FindGameObjectsWithTag("Edible");
            var edibles = edibleGameObjects.Select(e => e.GetComponent<EdibleDot>()).ToList();

            aggr.AddRange(edibles);

            iterator = aggr.CreateIterator();
            InvokeRepeating("MyMethod", 3f, 2f);*/
        }

        public void Update()
        {
        }

        public void MyMethod()
        {
            Debug.Log("Working");
            var iteratorValue = iterator.Next();
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
