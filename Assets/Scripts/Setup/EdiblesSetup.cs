﻿using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Patterns.Decorator;
using UnityEngine;
using Zenject;
using Random = System.Random;

namespace Assets.Scripts.Setup
{
    public class EdiblesSetup: MonoBehaviour
    {
        [Inject]
        private EdibleElementCreator dotCreator;

        public void Start()
        {
            EdibleElementCreator fruitCreator = new FruitCreatorDecorator(dotCreator);
            var rand = new System.Random();
            foreach (var coordinates in GenerateCoordinatesForEdibles())
            {
                if (rand.Next(1, 10) == 5)
                {
                    fruitCreator.CreateEdibleElement(coordinates);
                }
                else
                {
                    dotCreator.CreateEdibleElement(coordinates);
                }
            }
        }

        private class WallLimits
        {
            public float FromX;
            public float ToX;
            public float FromZ;
            public float ToZ;
        }

        private static List<Vector3> GenerateCoordinatesForEdibles()
        {
            var walls = GameObject.FindGameObjectsWithTag("Wall");
            List<WallLimits> wallLimits = walls.Select(w => new WallLimits
            {
                FromX = w.transform.position.x - (w.transform.localScale.x / 2f) - 2,
                ToX = w.transform.position.x + (w.transform.localScale.x / 2f) + 2,
                FromZ = w.transform.position.z - (w.transform.localScale.z / 2f) - 2,
                ToZ = w.transform.position.z + (w.transform.localScale.z / 2f) + 2,
            }).ToList();

            var xRange = Enumerable.Range(1, 99);
            var zRange = Enumerable.Range(1, 99);

            var allCoordinates = xRange.Select(x => zRange.Select(z => new Vector3(x, 1.5f, z)))
                .SelectMany(c => c)
                .Where(c => CompareToWallLimits(c, wallLimits));

            var result = Shuffle(allCoordinates.ToList())
                .Where((x, i) => i % 50 == 0)
                .ToList();
            
            return result;
        }

        private static bool CompareToWallLimits(Vector3 c, List<WallLimits> wallLimits)
        {
            var result = wallLimits.All(wl => (c.x < wl.FromX || c.x > wl.ToX || c.z < wl.FromZ || c.z > wl.ToZ));

            return result;
        }

        private static List<Vector3> Shuffle(List<Vector3> list)
        {
            int n = list.Count;
            Random rng = new Random();
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Vector3 value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

            return list;
        }
    }
}