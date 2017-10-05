namespace Assets.Scripts.Patterns.Builder.CharacterParts
{
    public class CharacterMouth: ICharacterMouth
    {
        public string Phrase { get; private set; }

        public CharacterMouth(string phrase)
        {
            Phrase = phrase;
        }

    }
}