using System.Collections.Generic;
using Assets.Scripts.Components;
using Assets.Scripts.Patterns.Factory;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Setup
{
    public class CharactersSetup: MonoBehaviour
    {
        [Inject]
        private CharacterBuilderFactory buildersFactory;

        public void Start()
        {
            var ghosts = new List<GameObject>();
            var pacman = buildersFactory
                .GetBuilder(BuilderType.Pacman)
                .Build();

            var ghostBuilder = buildersFactory.GetBuilder(BuilderType.Ghost);
            for (var i = 0; i < 5; i++)
            {
                ghosts.Add(ghostBuilder.Build());
            }

            GameObject
                .Find("PacmanCamera")
                .GetComponent<FollowingCamera>()
                .Player = pacman.GetComponent<PacmanComponent>();
        }
    }
}