namespace Assets.Scripts.Patterns.Builder.CharacterParts
{
    class SlowLegsFirstState: ICharacterLegs
    {
        public float Speed { get; private set; }

        public SlowLegsFirstState()
        {
            Speed = 10;
        }        
    }
}
