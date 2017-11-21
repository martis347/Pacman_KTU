using Assets.Scripts.Components;
using Assets.Scripts.Patterns.Builder.CharacterParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Patterns.State
{
    class SecondStateSpeed : IState
    {
        public void doAction(Context context)
        {
            context.setState(this);
        }

        public void decreasePacmanSpeed()
        {
            Debug.Log("Pacman speed decreased 2");
            GameObject.Find("Pacman!").GetComponent<PacmanComponent>().Legs = new SlowLegsSecondState();

        }
    }
}
