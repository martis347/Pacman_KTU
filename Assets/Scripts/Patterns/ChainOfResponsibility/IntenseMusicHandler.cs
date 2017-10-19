using UnityEngine;

namespace Assets.Scripts.Patterns.ChainOfResponsibility
{
    public class IntenseMusicHandler: MusicHandler
    {
        private string soundtrackName = "Intense_Soundtrack";
        public override void HandleMusic(int currentPoints)
        {
            if (currentPoints > 100)
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