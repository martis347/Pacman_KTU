namespace Assets.Scripts.Patterns.Builder.CharacterParts
{
    public class SlowLegs: ICharacterLegs
    {
        public float Speed { get; private set; }

        public SlowLegs()
        {
            Speed = 15;
        }

    }
}