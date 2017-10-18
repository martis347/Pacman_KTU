using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Patterns.Command
{
    class UnPauseCommand: MenuCommand
    {
        Pause Pause;

        public UnPauseCommand()
        {
            Pause = new Pause();
        }

        public void Execute()
        {
            Pause.StopPause();
        }
    }
}
