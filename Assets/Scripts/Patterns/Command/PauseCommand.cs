using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Patterns.Command
{
    class PauseCommand: MenuCommand
    {
        Pause pause;

        public PauseCommand()
        {
            this.pause = new Pause();
        }

        public void Execute()
        {
            this.pause.StartPause();
        }
    }
}
