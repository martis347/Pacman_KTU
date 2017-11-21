using System;
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
        public void Start()
        {
            logger = new ProxyLogger();
            transform.position = Position;
            transform.localScale = Body.Dimensions;
        }

        void Update()
        {
            CharacterController controller = GetComponent<CharacterController>();
            if (controller.isGrounded)
            {
                moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= Legs.Speed;
            }
            moveDirection.y -= Gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);
            HandleSpecialAbility(controller);

            if (transform.position.y < 0)
            {
                ScoreboardSingleton.Scoreboard.AddDeath();
                transform.position = Position;
                logger.LogMessage("Pacman has died!");
            }
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
    }
}