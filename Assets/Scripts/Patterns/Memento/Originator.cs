using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Patterns.Memento
{
    class Originator
    {
        private GameObject pacmanState;

        public void setState(GameObject pacmanState)
        {
            this.pacmanState = pacmanState;
        }

        public GameObject getState()
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
