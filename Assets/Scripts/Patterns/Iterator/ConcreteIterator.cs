using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Patterns.Iterator
{
    class ConcreteIterator : Iterator
    {
        private EdiblesList ediblesList;
        int index;

        public ConcreteIterator(EdiblesList ediblesList)
        {
            this.ediblesList = ediblesList;
            index = -1;
        }

        public bool Next()
        {
            index++;
            return index < ediblesList.Count;
        }

        public object Current
        {
            get
            {
                if (index < ediblesList.Count)
                    return ediblesList[index];
                else
                    throw new InvalidOperationException();
            }
        }

    }
}
