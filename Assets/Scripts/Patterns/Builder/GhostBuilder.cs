using Assets.Scripts.Components;
using Assets.Scripts.Patterns.Builder.CharacterParts;
using UnityEngine;

namespace Assets.Scripts.Patterns.Builder
{
    public class GhostBuilder: ICharacterBuilder
    {
        private GameObject gameObject;

        public GameObject Build()
        {
            gameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);

            gameObject.AddComponent<GhostComponent>().InjectAttributes(AssembleGhostComponent());
            gameObject.AddComponent<MeshCollider>();
            gameObject.AddComponent<CharacterController>();

            gameObject.name = "Ghost";
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
            ghost.Position = new Vector3(50f, ghost.Body.Height / 2f, 50);

            return ghost;
        }
    }
}