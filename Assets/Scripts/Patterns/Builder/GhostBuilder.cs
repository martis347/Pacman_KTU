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

            gameObject.transform.position = new Vector3(0, -10, 0);
            gameObject.AddComponent<GhostComponent>().InjectAttributes(AssembleGhostComponent());
            gameObject.AddComponent<CharacterController>();
            gameObject.AddComponent<Rigidbody>();

            var renderer = gameObject.GetComponent<Renderer>();
            renderer.material = Resources.Load<Material>("Blue");

            var collider = gameObject.GetComponent<SphereCollider>();
            collider.isTrigger = true;
            collider.radius = 0.6f;

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
            ghost.Position = GetRandomLocation(ghost.Body.Height);

            return ghost;
        }

        private Vector3 GetRandomLocation(float yAxis)
        {
            float xAxis = Random.value > 0.5 ? 35f : 65f;
            float zAxis = Random.value * 35 + 30;

            return new Vector3(xAxis, yAxis, zAxis);
        }
    }
}