using Assets.Scripts.Builder;
using Assets.Scripts.Builder.CharacterParts;
using UnityEngine;

namespace Assets.Scripts.Components
{
    public abstract class CharacterComponent: MonoBehaviour
    {
        public ICharacterBody Body;
        public ICharacterLegs Legs;
        public ICharacterMouth Mouth;
        public Vector3 Position;

        public CharacterComponent InjectAttributes(Character character)
        {
            Body = character.Body;
            Legs = character.Legs;
            Mouth = character.Mouth;
            Position = character.Position;

            return this;
        }
    }
}