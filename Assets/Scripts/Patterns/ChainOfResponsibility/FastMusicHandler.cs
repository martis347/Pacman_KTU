using UnityEngine;

namespace Assets.Scripts.Patterns.ChainOfResponsibility
{
    public class FastMusicHandler : MusicHandler
    {
        private string soundtrackName = "Fast_Soundtrack";
        public override void HandleMusic(int currentPoints)
        {
            if (currentPoints >= 50 && currentPoints <= 100)
            {
                if (AudioSource.clip == null || AudioSource.clip.name != soundtrackName)
                {
                    AudioSource.clip = AudioClips[soundtrackName];
                    AudioSource.Play();
                    AudioSource.loop = true;
                }
            }
            else if (FurtherHandler != null)
            {
                FurtherHandler.HandleMusic(currentPoints);
            }
        }
    }
}