﻿using UnityEngine;

namespace Assets.Scripts.Patterns.Decorator
{
    public class EdibleDotCreator: EdibleElementCreator
    {
        public override GameObject CreateEdibleElement(Vector3 coordinates)
        {
            var edibleDotGameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            edibleDotGameObject.AddComponent<MeshCollider>();
            edibleDotGameObject.AddComponent<EdibleDot>();

            var edibleDotComponent = edibleDotGameObject.GetComponent<EdibleDot>();
            edibleDotComponent.Points = 1;

            edibleDotGameObject.transform.position = coordinates;
            edibleDotGameObject.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);

            return edibleDotGameObject;
        }
    }
}