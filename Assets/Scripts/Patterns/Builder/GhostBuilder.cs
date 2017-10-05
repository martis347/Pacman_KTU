using Assets.Scripts.Builder;
using Assets.Scripts.Components;
using Assets.Scripts.Patterns.Builder.CharacterParts;
using UnityEngine;

namespace Assets.Scripts.Patterns.Builder
{
    public class GhostBuilder: ICharacterBuilder
    {
        private readonly GameObject gameObject;

        public GhostBuilder()
        {
            gameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        }

        public UnityEngine.GameObject Build()
        {
            gameObject.AddComponent<GhostComponent>().InjectAttributes(AssembleGhostComponent());

            return gameObject;
        }

        private Character AssembleGhostComponent()
        {
            var ghost = new Character
            {
                Legs = new SlowLegs(),
                Body = new SmallBody(),
                Mouth = new CharacterMouth("Boo, I'm a ghost!")
            };
            ghost.Position = new Vector3(25f, ghost.Body.Height / 2f, 35f);

            return ghost;
        }
    }
}