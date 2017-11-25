using Assets.Scripts.Patterns.Decorator;
using System.Collections.Generic;

namespace Assets.Scripts.Patterns.Iterator
{
    class EdiblesList : Edibles
    {
        private readonly List<EdibleDot> items = new List<EdibleDot>();

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

        public void AddRange(List<EdibleDot> edibles)
        {
            foreach(var edible in edibles)
            {
                items.Add(edible);
            }
        }

        public List<EdibleDot> GetList()
        {
            return items;
        }
    }
}
