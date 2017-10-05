using UnityEngine;

namespace Assets.Scripts.Patterns.Builder.CharacterParts
{
    public class SmallBody: ICharacterBody
    {
        public float Width { get; private set; }
        public float Height { get; private set; }
        public float Depth { get; private set; }
        public Vector3 Dimensions
        {
            get { return new Vector3(Width, Height, Depth); }
        }

        public SmallBody()
        {
            Width = 3;
            Depth = 3;
            Height = 3;
        }

    }
}