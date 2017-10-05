namespace Assets.Scripts.Patterns.Builder.CharacterParts
{
    public class FastLegs: ICharacterLegs
    {
        public float Speed { get; private set; }

        public FastLegs()
        {
            Speed = 20;
        }

    }
}