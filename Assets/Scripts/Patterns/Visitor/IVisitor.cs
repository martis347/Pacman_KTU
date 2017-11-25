using Assets.Scripts.Components;
using Assets.Scripts.Patterns.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Patterns.Visitor
{
    public interface IVisitor
    {
        void Visit(EdibleDot edibleDot);
        void Visit(GhostComponent ghost);
    }
}
