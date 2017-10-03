using UnityEngine;

namespace Assets.Scripts.Patterns.Strategy
{
    public interface ISpecialPacmanAbility
    {
        void DoSpecialAbility(CharacterController gameObject, GameObject o);
    }
}