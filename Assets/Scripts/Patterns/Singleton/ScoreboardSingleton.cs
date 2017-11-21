using Assets.Scripts.Patterns.State;

namespace Assets.Scripts.Patterns.Singleton
{
    public sealed class ScoreboardSingleton
    {
        private static ScoreboardSingleton instance;
        private static readonly object Padlock = new object();
        private readonly Scoreboard scoreboard;

        Context context = new Context();

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

        public void AddPoints(int points)
        {
            lock (Padlock)
            {
                scoreboard.PointsScored += points;
                if(scoreboard.PointsScored > 30 && scoreboard.PointsScored < 50)
                {
                    FirstStateSpeed firstStateSpeed = new FirstStateSpeed();
                    firstStateSpeed.decreasePacmanSpeed();
                } else if (scoreboard.PointsScored > 50)
                {
                    SecondStateSpeed secondStateSpeed = new SecondStateSpeed();
                    secondStateSpeed.decreasePacmanSpeed();
                }
            }
        }
    }
}