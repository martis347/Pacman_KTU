using UnityEngine;

namespace Assets.Scripts
{
    public class FollowingCamera : MonoBehaviour
    {
        public KeyboardSphere Player;       //Public variable to store a reference to the player game object
        private Vector3 offset;         //Private variable to store the offset distance between the player and camera

        void Start()
        {
            var rb = GetComponent<Rigidbody>();
            offset = transform.position - Player.transform.position;
        }

        void Update()
        {
            transform.position = Player.transform.position + offset;
        }
    }
}