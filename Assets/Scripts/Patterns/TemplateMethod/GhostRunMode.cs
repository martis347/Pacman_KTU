using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Patterns.TemplateMethod
{
    class GhostRunMode : AbstractGhostMovement
    {
        public GhostRunMode(Vector3 currentPosition, Vector3 targetPosition, Rigidbody rb) : base(currentPosition, targetPosition, rb)
        {
        }

        protected override Vector3 FindDestinationSpot()
        {
            //@TODO implement it later
            throw new NotImplementedException();
        }
    }
}
