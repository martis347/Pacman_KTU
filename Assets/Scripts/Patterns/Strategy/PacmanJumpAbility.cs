using UnityEngine;

namespace Assets.Scripts.Patterns.Strategy
{
    public class PacmanJumpAbility: ISpecialPacmanAbility
    {
        public void DoSpecialAbility(CharacterController controller, GameObject gameObject)
        {
            if (gameObject.transform.position.y < 8)
            {
                controller.Move(new Vector3(0, 15, 0));
            }
        }
    }
}