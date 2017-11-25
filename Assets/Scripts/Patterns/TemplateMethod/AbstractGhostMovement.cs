using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.Patterns.TemplateMethod
{
    abstract class AbstractGhostMovement
    {
        protected Vector3 CurrentPosition;
        protected Vector3 TargetPosition;
        protected Rigidbody Rb;

        public AbstractGhostMovement(Vector3 currentPosition, Vector3 targetPosition, Rigidbody rb)
        {
            this.CurrentPosition = currentPosition;
            this.TargetPosition = targetPosition;
            this.Rb = rb;
        }

        public void Move()
        {
            Vector3 movement = FindDestinationSpot();
            Rb.MovePosition(movement);
        }

        protected abstract Vector3 FindDestinationSpot();
    }
}
