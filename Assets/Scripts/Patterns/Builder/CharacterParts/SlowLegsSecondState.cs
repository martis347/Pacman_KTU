using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Patterns.Builder.CharacterParts
{
    class SlowLegsSecondState: ICharacterLegs
    {
        public float Speed { get; private set; }

        public SlowLegsSecondState()
        {
            Speed = 5;
        }


    }
}
