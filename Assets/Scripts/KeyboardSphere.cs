using UnityEngine;

namespace Assets.Scripts
{
    public class KeyboardSphere : MonoBehaviour
    {
        public float speed;
        void Start()
        {
        }

        void FixedUpdate()
        {
            transform.Translate(Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed, 0f, Input.GetAxis("Vertical") * Time.fixedDeltaTime * speed);
        }
    }
}
