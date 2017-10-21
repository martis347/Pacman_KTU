using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Patterns.Iterator
{
    interface Aggregate
    {
        Iterator CreateIterator();
    }
}
