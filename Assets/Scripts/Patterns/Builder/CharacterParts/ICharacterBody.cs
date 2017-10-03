using UnityEngine;

namespace Assets.Scripts.Builder.CharacterParts
{
    public interface ICharacterBody
    {
        float Width { get; }
        float Height { get; }
        float Depth { get; }
        Vector3 Dimensions { get; }
    }
}