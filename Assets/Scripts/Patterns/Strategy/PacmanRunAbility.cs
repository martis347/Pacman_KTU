using UnityEngine;

namespace Assets.Scripts.Patterns.Strategy
{
    public class PacmanRunAbility: ISpecialPacmanAbility
    {
        public void DoSpecialAbility(CharacterController controller, GameObject gameObject)
        {
            var moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = gameObject.transform.TransformDirection(moveDirection);

            controller.Move(moveDirection * Time.deltaTime * 1000);
        }
    }
}