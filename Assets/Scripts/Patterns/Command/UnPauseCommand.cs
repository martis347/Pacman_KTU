using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Patterns.Command
{
    class UnPauseCommand: MenuCommand
    {
        Pause pause;

        public UnPauseCommand()
        {
            this.pause = new Pause();
        }

        public void Execute()
        {
            this.pause.StopPause();
        }
    }
}
