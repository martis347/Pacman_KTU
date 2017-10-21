using Assets.Scripts.Patterns.Singleton;

namespace Assets.Scripts.Patterns.Adapter
{
    public class ScoreboardAdapter: ScoreboardCheat
    {
        private readonly ScoreboardSingleton scoreboard;

        public ScoreboardAdapter(ScoreboardSingleton scoreboard)
        {
            this.scoreboard = scoreboard;
        }

        public override void AddFruitCollected()
        {
            scoreboard.AddPoints(5);
        }

        public override void AddFortyDotsCollected()
        {
            scoreboard.AddPoints(40);
        }

        public override void FakeADeath()
        {
            scoreboard.AddDeath();
        }
    }
}