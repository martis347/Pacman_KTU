using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Patterns.State
{
    interface IState
    {
        void doAction(Context context);
    }
}
