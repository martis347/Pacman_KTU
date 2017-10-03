using UnityEngine;

namespace Assets.Scripts.Components
{
    public class PacmanComponent: CharacterComponent
    {
        private float Speed = 30F;
        private float Gravity = 20.0F;
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
                moveDirection *= Speed;

            }
            moveDirection.y -= Gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);
        }
    }
}