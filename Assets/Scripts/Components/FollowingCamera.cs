using UnityEngine;

namespace Assets.Scripts.Components
{
    public class FollowingCamera : MonoBehaviour
    {
        public CharacterComponent Player;
        private Vector3 offset;

        void Start()
        {
            offset = new Vector3(0, 60, 0);
            transform.eulerAngles = new Vector3(90, 0, 0);
        }

        void Update()
        {
            transform.position = Player.transform.position + offset;
        }
    }
}