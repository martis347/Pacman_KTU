using System;
using Assets.Scripts.Patterns.Proxy;
using UnityEngine;
using Random = UnityEngine.Random;
using Assets.Scripts.Patterns.Visitor;
using Assets.Scripts.Patterns.TemplateMethod;

namespace Assets.Scripts.Components
{
    public class GhostComponent: CharacterComponent, IVisitable
    {
        private float Gravity = 100f;
        private Vector3 moveDirection;
        private float xAxis;
        private float zAxis;
        private float ghostSpeed = 50;
        private IGameLogger logger;
        private int prevValue = 3;

        public void Start()
        {
            transform.position = Position;
            transform.localScale = Body.Dimensions;
            logger = new ProxyLogger();

            xAxis = 1f;
            zAxis = 0f;
        }
        public void Update()
        {
            CharacterController controller = GetComponent<CharacterController>();
            if (controller.isGrounded)
            {
                moveDirection = new Vector3(xAxis / 100 * ghostSpeed, 0, zAxis / 100 * ghostSpeed);
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= Legs.Speed;
            }
            moveDirection.y -= Gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);
        }

        public void OnPacmanStep(PacmanComponent pacman)
        {
            GhostChaseMode ghostMode = new GhostChaseMode(pacman.Position, moveDirection, this.GetComponent<Rigidbody>());
            ghostMode.Move();
        }

        public void OnTriggerEnter(Collider collider)
        {
            if (collider.gameObject.tag == "Wall")
            {
                Debug.Log(collider.gameObject.name);
                ChangeDirection();
            }
        }

        private void ChangeDirection()
        {
            int value;
            while ((value = Mathf.FloorToInt(Random.value * 4)) == prevValue)
            {
                
            }
            prevValue = value;

            if (value == 0)
            {
                xAxis = 0f;
                zAxis = -1f;
            } 
            else if (value == 1)
            {
                xAxis = -1f;
                zAxis = 0f;
            }
            else if (value == 2)
            {
                xAxis = 0f;
                zAxis = 1f;
            }
            else
            {
                xAxis = 1f;
                zAxis = 0;
            }
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}