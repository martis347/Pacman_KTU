using Assets.Scripts.Patterns.ChainOfResponsibility;
using Assets.Scripts.Patterns.Singleton;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Setup
{
    public class MusicSetup: MonoBehaviour
    {
        [Inject(Id = "Light")]
        private MusicHandler lightMusicHandler;
        [Inject(Id = "Fast")]
        private MusicHandler fastMusicHandler;
        [Inject(Id = "Intense")]
        private MusicHandler intenseMusicHandler;

        public void Start()
        {
            lightMusicHandler.SetSuccessor(fastMusicHandler);
            fastMusicHandler.SetSuccessor(intenseMusicHandler);
        }

        public void Update()
        {
            var score = ScoreboardSingleton.Scoreboard.GetScore();
            lightMusicHandler.HandleMusic(score.PointsScored);
        }
    }
}