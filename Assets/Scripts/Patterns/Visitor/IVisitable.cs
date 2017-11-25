using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Patterns.Visitor
{
    interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}
