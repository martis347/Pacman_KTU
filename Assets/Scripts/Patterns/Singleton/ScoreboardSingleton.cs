namespace Assets.Scripts.Patterns.Singleton
{
    public sealed class ScoreboardSingleton
    {
        private static ScoreboardSingleton instance;
        private static readonly object Padlock = new object();
        private readonly Scoreboard scoreboard;

        private ScoreboardSingleton()
        {
            scoreboard = new Scoreboard();
        }

        public static ScoreboardSingleton Scoreboard
        {
            get
            {
                lock (Padlock)
                {
                    return instance ?? (instance = new ScoreboardSingleton());
                }
            }
        }

        public Scoreboard GetScore()
        {
            lock (Padlock)
            {
                return scoreboard;
            }
        }

        public void AddDeath()
        {
            lock (Padlock)
            {
                scoreboard.PacmanDeaths += 1;
            }
        }

        public void AddPoint()
        {
            lock (Padlock)
            {
                scoreboard.PointsScored += 1;
            }
        }
    }
}