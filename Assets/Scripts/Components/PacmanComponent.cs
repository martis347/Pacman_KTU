using System;
using Assets.Scripts.Patterns.Interpreter;
using Assets.Scripts.Patterns.Proxy;
using Assets.Scripts.Patterns.Singleton;
using Assets.Scripts.Patterns.Strategy;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Components
{
    public class PacmanComponent: CharacterComponent
    {
        private ISpecialPacmanAbility ability = new PacmanNullAbility();

        private float Gravity = 100f;
        private Vector3 moveDirection = Vector3.zero;
        private IGameLogger logger;
        private CharacterController controller;
        private Direction direction;
        public void Start()
        {
            logger = new ProxyLogger();
            transform.position = Position;
            transform.localScale = Body.Dimensions;
        }

        void Update()
        {
            Move();
            controller = GetComponent<CharacterController>();
            HandleSpecialAbility(controller);

            if (transform.position.y < 0)
            {
                ScoreboardSingleton.Scoreboard.AddDeath();
                transform.position = Position;
                logger.LogMessage("Pacman has died!");
            }
        }

        private void Move(float x = 0, float y = 0)
        {
            if (x == 0)
            {
                x = Input.GetAxis("Horizontal");
            }
            if (y == 0)
            {
                y = Input.GetAxis("Vertical");
            }

            controller = GetComponent<CharacterController>();
            if (controller.isGrounded)
            {
                moveDirection = new Vector3(x, 0, y);
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= Legs.Speed;
            }
            moveDirection.y -= Gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);
        }

        private void HandleSpecialAbility(CharacterController controller)
        {
            if (Input.GetKeyDown("1"))
            {
                logger.LogMessage("Run Ability Activated!");
                ability = new PacmanRunAbility();
            }
            else if (Input.GetKeyDown("2"))
            {
                logger.LogMessage("Jump Ability Activated!");
                ability = new PacmanJumpAbility();
            }
            else if (Input.GetKeyDown("3"))
            {
                logger.LogMessage("Teleport Ability Activated!");
                ability = new PacmanTeleportAbility();
            }

            if (Input.GetKeyDown("space"))
            {
                ability.DoSpecialAbility(controller, gameObject);
            }
        }

        public void SetDirection(Direction direction)
        {
            this.direction = direction;
        }

        public void MoveSteps(int stepsToTake)
        {
            float x = 0, y = 0;
            switch (direction)
            {
                case Direction.Forward:
                    y = stepsToTake * 3;
                    break;
                case Direction.Backwards:
                    y = stepsToTake * -3;
                    break;
                case Direction.Left:
                    x = stepsToTake * 3;
                    break;
                case Direction.Right:
                    x = stepsToTake * -3;
                    break;
                default:
                    x = 0;
                    y = 0;
                    break;
            }

            Move(x, y);
        }
    }
}