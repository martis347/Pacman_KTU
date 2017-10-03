using UnityEngine;

namespace Assets.Scripts.Patterns.Strategy
{
    public class PacmanTeleportAbility: ISpecialPacmanAbility
    {
        public void DoSpecialAbility(CharacterController controller, GameObject gameObject)
        {
            var random = new System.Random();
            if (random.Next(0, 3) == 0)
            {
                gameObject.transform.position = new Vector3(5f, 2.5f, 5f);
            }
            else if (random.Next(0, 3) == 1)
            {
                gameObject.transform.position = new Vector3(95f, 2.5f, 5f);
            }
            else if (random.Next(0, 3) == 2)
            {
                gameObject.transform.position = new Vector3(5f, 2.5f, 95f);
            }
            else
            {
                gameObject.transform.position = new Vector3(95f, 2.5f, 95f);
            }
        }
    }
}