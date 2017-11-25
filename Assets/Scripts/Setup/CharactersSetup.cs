using System.Collections.Generic;
using Assets.Scripts.Components;
using Assets.Scripts.Patterns.Factory;
using Assets.Scripts.Patterns.Interpreter;
using UnityEngine;
using Zenject;
using Context = Zenject.Context;

namespace Assets.Scripts.Setup
{
    public class CharactersSetup: MonoBehaviour
    {
        [Inject]
        private CharacterBuilderFactory buildersFactory;

        private Patterns.Interpreter.Context context;
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

            context = new Patterns.Interpreter.Context(pacman.GetComponent<PacmanComponent>(), "w5d2w9d3s1a4");

            //InvokeRepeating("DoAction", 5f, 0.3f);
        }

        public void DoAction()
        {
            if (context.NotEmpty())
            {
                var directionExpression = new DirectionExpression();
                directionExpression.Interpret(context);
                var stepsExpression = new StepsExpression();
                stepsExpression.Interpret(context);
            }
        }
    }
}