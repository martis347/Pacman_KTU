using Assets.Scripts.Patterns.Adapter;
using Assets.Scripts.Patterns.Singleton;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Patterns.Command;

namespace Assets.Scripts.Setup
{
    public class PauseSetup : MonoBehaviour
    {
        PauseCommand pauseCommand;
        UnPauseCommand unPauseCommand;

        PauseSetup()
        {
            this.pauseCommand = new PauseCommand();
            this.unPauseCommand = new UnPauseCommand();
        }

        public void Start()
        {
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if(Time.timeScale == 1)
                {
                    this.pauseCommand.Execute();
                }
                else if (Time.timeScale == 0)
                {
                    this.unPauseCommand.Execute();
                }
            }

        }
    }
}