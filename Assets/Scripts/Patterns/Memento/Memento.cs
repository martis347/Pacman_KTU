using Assets.Scripts.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Patterns.Memento
{
    class Memento
    {
        private PacmanComponent pacmanState;

        public Memento(PacmanComponent pacmanState)
        {
            this.pacmanState = pacmanState;
        }

        public PacmanComponent getPacmanState()
        {
            return pacmanState;
        }
    }
}
