using Assets.Scripts.Patterns.Decorator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Patterns.Iterator
{
    class ConcreteAggregate : Aggregate
    {
        private List<EdibleDot> items = new List<EdibleDot>();

        public Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public object this[int index]
        {
            get { return items[index]; }
        }

        public int Count
        {
            get { return items.Count; }
        }

        /*public void Add(object o)
        {
            items.Add(o);
        }*/

        public void AddRange(List<EdibleDot> edibles)
        {
            foreach(var edible in edibles)
            {
                items.Add(edible);
            }
        }
    }
}
