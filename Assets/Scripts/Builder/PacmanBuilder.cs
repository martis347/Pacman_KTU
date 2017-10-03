using Assets.Scripts.Builder.CharacterParts;
using Assets.Scripts.Components;
using UnityEngine;

namespace Assets.Scripts.Builder
{
    public class PacmanBuilder: ICharacterBuilder
    {
        private readonly UnityEngine.GameObject gameObject;

        public PacmanBuilder()
        {
            gameObject = UnityEngine.GameObject.CreatePrimitive(PrimitiveType.Sphere);
        }

        public UnityEngine.GameObject Build()
        {
            gameObject.AddComponent<PacmanComponent>().InjectAttributes(AssemblePacmanComponent());
            gameObject.AddComponent<CharacterController>();
            gameObject.AddComponent<MeshRenderer>();
            gameObject.AddComponent<Animation>();
            gameObject.AddComponent<MeshFilter>();
            gameObject.AddComponent<MeshCollider>();
            gameObject.AddComponent<Renderer>();

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