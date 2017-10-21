namespace Assets.Scripts.Patterns.ChainOfResponsibility
{
    public class LightMusicHandler : MusicHandler
    {
        private string soundtrackName = "Light_Soundtrack";
        public override void HandleMusic(int currentPoints)
        {
            if (currentPoints < 50)
            {
                if (AudioSource.clip == null || AudioSource.clip.name != soundtrackName)
                {
                    AudioSource.clip = AudioClips[soundtrackName];
                    AudioSource.Play();
                    AudioSource.loop = true;
                }
            }
            else if(FurtherHandler != null)
            {
                FurtherHandler.HandleMusic(currentPoints);
            }
        }

        
    }
}