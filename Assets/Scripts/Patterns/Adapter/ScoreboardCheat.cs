namespace Assets.Scripts.Patterns.Adapter
{
    public abstract class ScoreboardCheat
    {
        public abstract void AddFruitCollected();
        public abstract void AddFortyDotsCollected();
        public abstract void FakeADeath();
    }
}