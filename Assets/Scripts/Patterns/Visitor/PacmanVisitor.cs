using Assets.Scripts.Components;
using Assets.Scripts.Patterns.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Patterns.Visitor
{
    public class PacmanVisitor : IVisitor
    {
        PacmanComponent pacman;

        public PacmanVisitor(PacmanComponent pacman)
        {
            this.pacman = pacman;
        }

        public void Visit(EdibleDot edibleDot)
        {
            edibleDot.OnPacmanMove();
        }

        public void Visit(GhostComponent ghost)
        {
            ghost.OnPacmanStep(pacman);
        }
    }
}
