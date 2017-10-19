using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Patterns.Command
{
    class PauseCommand: MenuCommand
    {
        Pause Pause;

        public PauseCommand()
        {
            Pause = new Pause();
        }

        public void Execute()
        {
            Pause.StartPause();
        }
    }
}
