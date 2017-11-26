using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Patterns.TemplateMethod
{
    class GhostNormalMode : AbstractGhostMovement
    {
        public GhostNormalMode(Vector3 currentPosition, Vector3 targetPosition, Rigidbody rb) : base(currentPosition, targetPosition, rb)
        {
        }

        protected override Vector3 FindDestinationSpot()
        {
            Vector3 newPosition = CurrentPosition;

            if (UnityEngine.Random.value > .5)
            {
               
            }
            else
            {
               
            }
            if (UnityEngine.Random.value > .5)
            {
                
            }
            else
            {
                
            }

            return newPosition;
        }

//        private GameObject FindFarestWall()
//        {
//            GameObject[] walls = GameObject.FindGameObjectsWithTag("Wall");
//            GameObject farest = null;
//            float distance = Mathf.Infinity;
//            foreach (GameObject wall in walls)
//            {
//                Vector3 diff = wall.transform.position - CurrentPosition;
//                float curDistance = diff.sqrMagnitude;
//                if (curDistance > distance)
//                {
//                    farest = wall;
//                    distance = curDistance;
//                }
//            }
//            return farest;
//        }
    }
}
