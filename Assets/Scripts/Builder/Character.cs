using Assets.Scripts.Builder.CharacterParts;
using UnityEngine;

namespace Assets.Scripts.Builder
{
    public class Character
    {
        public ICharacterBody Body;
        public ICharacterLegs Legs;
        public ICharacterMouth Mouth;
        public Vector3 Position;
    }
}