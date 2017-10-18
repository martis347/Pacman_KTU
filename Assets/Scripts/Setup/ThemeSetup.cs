using Assets.Scripts.Patterns.Bridge;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Assets.Scripts.Setup
{
    public class ThemeSetup: MonoBehaviour
    {
        [Inject]
        private GameTheme theme;

        [Inject(Id = "Light")]
        private BridgePainter lightPainter;

        [Inject(Id = "Dark")]
        private BridgePainter darkPainter;

        public void Start()
        {
            var toggleEvent = new Toggle.ToggleEvent();
            gameObject.GetComponent<Toggle>().onValueChanged = toggleEvent;
            theme.BridgePainter = lightPainter;

            toggleEvent.AddListener(Toggle_Changed);
        }

        private void Toggle_Changed(bool newValue)
        {
            if (newValue)
            {
                theme.BridgePainter = darkPainter;
                PaintScene();
            }
            else
            {
                theme.BridgePainter = lightPainter;
                PaintScene();
            }
        }

        private void PaintScene()
        {
            theme.SetFloorColor();
            theme.SetGameBackgroundColor();
            theme.SetWallsColor();
        }
    }
}