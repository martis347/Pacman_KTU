﻿using System;
using Assets.Scripts.Patterns.Builder;

namespace Assets.Scripts.Patterns.Factory
{
    public class CharacterBuilderFactory
    {
        public ICharacterBuilder GetBuilder(BuilderType type)
        {
            switch (type)
            {
                case BuilderType.Ghost:
                    return new GhostBuilder();
                case BuilderType.Pacman:
                    return new PacmanBuilder();
                default:
                    throw new Exception("Builder with type " + type + " not found");
            }
        }
    }
}