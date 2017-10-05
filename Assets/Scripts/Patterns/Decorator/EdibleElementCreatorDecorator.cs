using UnityEngine;

namespace Assets.Scripts.Patterns.Decorator
{
    public abstract class EdibleElementCreatorDecorator: EdibleElementCreator
    {
        protected readonly EdibleElementCreator ElementCreator;

        protected EdibleElementCreatorDecorator(EdibleElementCreator elementCreator)
        {
            ElementCreator = elementCreator;
        }

        public override GameObject CreateEdibleElement(Vector3 coordinates)
        {
            if (ElementCreator != null)
            {
                return ElementCreator.CreateEdibleElement(coordinates);
            }

            return null;
        }
    }
}