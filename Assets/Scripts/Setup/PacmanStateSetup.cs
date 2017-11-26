using Assets.Scripts.Components;
using Assets.Scripts.Patterns.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Setup
{
    class PacmanStateSetup : MonoBehaviour
    {

        Originator originator = new Originator();
        CareTaker careTaker = new CareTaker();

        public void Start()
        {
            var buttonEvent = new Button.ButtonClickedEvent();
            gameObject.GetComponent<Button>().onClick = buttonEvent;
            buttonEvent.AddListener(TaskOnClick);
        }

        private void TaskOnClick()
        {
            Debug.Log("You have added pacman state to the array");
            PacmanComponent pacman = GameObject.Find("Pacman!").GetComponent<PacmanComponent>();
            originator.setState(pacman);
            careTaker.add(originator.saveStateToMemento());
        }
    }
}
