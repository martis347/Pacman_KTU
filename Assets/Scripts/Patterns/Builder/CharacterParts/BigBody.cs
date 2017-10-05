using UnityEngine;

namespace Assets.Scripts.Patterns.Builder.CharacterParts
{
    public class BigBody: ICharacterBody
    {
        public float Width { get; private set; }
        public float Height { get; private set; }
        public float Depth { get; private set; }

        public Vector3 Dimensions
        {
            get { return new Vector3(Width, Height, Depth); }
        }

        public BigBody()
        {
            Width = 5;
            Height = 5;
            Depth = 5;
        }
    }
}