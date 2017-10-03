using System.Collections.Generic;
using Assets.Scripts.Components;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Builder
{
    public class CharactersSetup: MonoBehaviour
    {
        [Inject(Id = "GhostBuilder")]
        private ICharacterBuilder ghostBuilder;

        [Inject(Id = "PacmanBuilder")]
        private ICharacterBuilder pacmanBuilder;

        public void Start()
        {
            var ghosts = new List<UnityEngine.GameObject>();

            var pacman = pacmanBuilder.Build();

            for (var i = 0; i < 5; i++)
            {
                ghosts.Add(ghostBuilder.Build());
            }

            UnityEngine.GameObject
                .Find("PacmanCamera")
                .GetComponent<FollowingCamera>()
                .Player = pacman.GetComponent<PacmanComponent>();

        }

        public void LateUpdate()
        {
            
        }

        public void FixedUpdate()
        {
        }
    }
}