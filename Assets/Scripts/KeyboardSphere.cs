using UnityEngine;

namespace Assets.Scripts
{
    public class KeyboardSphere : MonoBehaviour
    {
        public float Speed = 30F;
        public float Gravity = 20.0F;

        private Vector3 moveDirection = Vector3.zero;
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
