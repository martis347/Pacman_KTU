using UnityEngine;

namespace Assets.Scripts.Components
{
    public class GhostComponent: CharacterComponent
    {
        private float Gravity = 100f;
        private Vector3 moveDirection;

        public void Update()
        {
            CharacterController controller = GetComponent<CharacterController>();
            if (controller.isGrounded)
            {
                moveDirection = new Vector3(0.2f, 0, 0);
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= Legs.Speed;
            }
            moveDirection.y -= Gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);
        }
    }
}