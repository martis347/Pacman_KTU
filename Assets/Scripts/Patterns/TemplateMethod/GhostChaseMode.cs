using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Patterns.TemplateMethod
{
    class GhostChaseMode : AbstractGhostMovement
    {
        public GhostChaseMode(Vector3 currentPosition, Vector3 targetPosition, Rigidbody rb) : base(currentPosition, targetPosition, rb)
        {
            
        }

        protected override Vector3 FindDestinationSpot()
        {
            return Vector3.MoveTowards(
                CurrentPosition,
                TargetPosition,
                10f * Time.deltaTime
            );
        }
    }
}
