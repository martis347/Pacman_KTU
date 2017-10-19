using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Patterns.Command
{
    public class Pause : MonoBehaviour
    {
        public void StartPause()
        {
            Time.timeScale = 0;
        }

        public void StopPause()
        {
            Time.timeScale = 1;
        }
    }
}
