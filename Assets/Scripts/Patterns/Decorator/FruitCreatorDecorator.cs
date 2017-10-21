using UnityEngine;

namespace Assets.Scripts.Patterns.Decorator
{
    public class FruitCreatorDecorator: EdibleElementCreatorDecorator
    {
        public FruitCreatorDecorator(EdibleElementCreator elementCreator): base(elementCreator)
        {

        }

        public override GameObject CreateEdibleElement(Vector3 coordinates)
        {
            var gameObject = ElementCreator.CreateEdibleElement(coordinates);
            var edibleDotComponent = gameObject.GetComponent<EdibleDot>();
            edibleDotComponent.Points = 5;

            gameObject.transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
            var renderer = gameObject.GetComponent<Renderer>();
            renderer.material = Resources.Load<Material>("Red");

            gameObject.name = "Fruit";
            edibleDotComponent.tag = "Edible";

            return gameObject;
        }
    }
}