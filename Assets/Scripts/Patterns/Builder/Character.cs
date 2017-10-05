using Assets.Scripts.Patterns.Builder.CharacterParts;
using UnityEngine;

namespace Assets.Scripts.Patterns.Builder
{
    public class Character
    {
        public ICharacterBody Body;
        public ICharacterLegs Legs;
        public ICharacterMouth Mouth;
        public Vector3 Position;
    }
}