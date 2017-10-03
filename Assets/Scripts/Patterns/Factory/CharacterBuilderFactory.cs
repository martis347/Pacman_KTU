using System;
using Assets.Scripts.Builder;

namespace Assets.Scripts.Factory
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