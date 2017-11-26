using UnityEngine;

namespace Assets.Scripts.Patterns.Strategy
{
    public class PacmanNullAbility: ISpecialPacmanAbility
    {
        public void DoSpecialAbility(CharacterController gameObject, GameObject o)
        {
            //Do nothing
        }
    }
}