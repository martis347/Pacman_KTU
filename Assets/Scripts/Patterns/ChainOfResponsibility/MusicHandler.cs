using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Patterns.ChainOfResponsibility
{
    public abstract class MusicHandler
    {
        public abstract void HandleMusic(int currentPoints);
        protected MusicHandler FurtherHandler;
        protected readonly AudioSource AudioSource = GameObject.Find("AudioElement").GetComponent<AudioSource>();
        protected readonly Dictionary<string, AudioClip> AudioClips;

        public MusicHandler()
        {
            AudioClips = new Dictionary<string, AudioClip>
            {
                { "Light_Soundtrack", (AudioClip)Resources.Load("Audio/Light_Soundtrack")},
                { "Fast_Soundtrack", (AudioClip)Resources.Load("Audio/Fast_Soundtrack")},
                { "Intense_Soundtrack", (AudioClip)Resources.Load("Audio/Intense_Soundtrack")}
            };
        }

        public void SetSuccessor(MusicHandler handler)
        {
            FurtherHandler = handler;
        }

        protected FileInfo GetAudioFile(string fileName)
        {
            var dir = new DirectoryInfo("Assets/Audio");

            return dir.GetFiles(fileName).FirstOrDefault();
        }
    }
}