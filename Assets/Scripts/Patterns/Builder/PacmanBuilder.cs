using Assets.Scripts.Components;
using Assets.Scripts.Patterns.Builder.CharacterParts;
using UnityEngine;

namespace Assets.Scripts.Patterns.Builder
{
    public class PacmanBuilder: ICharacterBuilder
    {
        private readonly GameObject gameObject;

        public PacmanBuilder()
        {
            gameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        }

        public GameObject Build()
        {
            gameObject.AddComponent<PacmanComponent>().InjectAttributes(AssemblePacmanComponent());
            gameObject.AddComponent<CharacterController>();
            gameObject.AddComponent<Animation>();
            gameObject.AddComponent<MeshCollider>();

            var renderer = gameObject.GetComponent<Renderer>();
            renderer.material = Resources.Load<Material>("Yellow");
            gameObject.name = "Pacman!";

            return gameObject;
        }

        private Character AssemblePacmanComponent()
        {
            var pacman = new Character
            {
                Legs = new FastLegs(),
                Body = new BigBody(),
                Mouth = new CharacterMouth("Pac, Pac, Pac - MAN!")
            };
            pacman.Position = new Vector3(25f, pacman.Body.Height / 2f, 35f);

            return pacman;
        }

    }
}