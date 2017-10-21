using UnityEngine;
using Assets.Scripts.Patterns.Command;

namespace Assets.Scripts.Setup
{
    public class PauseSetup : MonoBehaviour
    {
        PauseCommand PauseCommand;
        UnPauseCommand UnPauseCommand;

        PauseSetup()
        {
            this.PauseCommand = new PauseCommand();
            this.UnPauseCommand = new UnPauseCommand();
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
                    this.PauseCommand.Execute();
                }
                else if (Time.timeScale == 0)
                {
                    this.UnPauseCommand.Execute();
                }
            }

        }
    }
}