using UnityEngine;

namespace Assets.Scripts.Patterns.Decorator
{
    public abstract class EdibleElementCreator
    {
        public abstract GameObject CreateEdibleElement(Vector3 coordinates);
    }
}