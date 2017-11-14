using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Patterns.State
{
    class Context
    {
        private IState state;

        public Context()
        {
            state = null;
        }

        public void setState(IState newState)
        {
            state = newState;
        }

        public IState getState()
        {
            return state;
        }
    }
}
