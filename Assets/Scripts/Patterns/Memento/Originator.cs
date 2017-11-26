using Assets.Scripts.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Patterns.Memento
{
    class Originator
    {
        private PacmanComponent pacmanState;

        public void setState(PacmanComponent pacmanState)
        {
            this.pacmanState = pacmanState;
        }

        public PacmanComponent getState()
        {
            return pacmanState;
        }

        public Memento saveStateToMemento()
        {
            return new Memento(pacmanState);
        }

        public void getStateFromMemento(Memento memento)
        {
            pacmanState = memento.getPacmanState();
        }
    }
}
