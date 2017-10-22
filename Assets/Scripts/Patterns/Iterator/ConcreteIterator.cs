using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Patterns.Iterator
{
    class ConcreteIterator : Iterator
    {
        private ConcreteEdibles concreteEdibles;
        int index;

        public ConcreteIterator(ConcreteEdibles concreteEdibles)
        {
            this.concreteEdibles = concreteEdibles;
            index = -1;
        }

        public bool Next()
        {
            index++;
            return index < concreteEdibles.Count;
        }

        public object Current
        {
            get
            {
                if (index < concreteEdibles.Count)
                    return concreteEdibles[index];
                else
                    throw new InvalidOperationException();
            }
        }

    }
}
