using Assets.Scripts.Patterns.Strategy;
using UnityEngine;

namespace Assets.Scripts.Components
{
    public class PacmanComponent: CharacterComponent
    {
        private ISpecialPacmanAbility ability;

        private float Gravity = 100f;
        private Vector3 moveDirection = Vector3.zero;

        public void Start()
        {
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

        }

        private void HandleSpecialAbility(CharacterController controller)
        {
            if (Input.GetKeyDown("1"))
            {
                ability = new PacmanRunAbility();
            }
            else if (Input.GetKeyDown("2"))
            {
                ability = new PacmanJumpAbility();
            }
            else if (Input.GetKeyDown("3"))
            {
                ability = new PacmanTeleportAbility();
            }

            if (Input.GetKeyDown("space") && ability != null)
            {
                ability.DoSpecialAbility(controller, gameObject);
            }
        }
    }
}