using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Patterns.Memento
{
    class Memento
    {
        private GameObject pacmanState;

        public Memento(GameObject pacmanState)
        {
            this.pacmanState = pacmanState;
        }

        public GameObject getPacmanState()
        {
            return pacmanState;
        }
    }
}
