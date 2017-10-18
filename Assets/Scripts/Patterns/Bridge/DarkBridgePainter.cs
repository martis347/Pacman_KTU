using UnityEngine;

namespace Assets.Scripts.Patterns.Bridge
{
    public class DarkBridgePainter: BridgePainter
    {
        public override void PaintBackground()
        {
            var camera = GameObject.Find("PacmanCamera").GetComponent<Camera>();
            camera.clearFlags = CameraClearFlags.SolidColor;
            camera.backgroundColor = Color.Lerp(Color.black, Color.black, 15);
        }

        public override void PaintWalls()
        {
            foreach (var wall in GameObject.FindGameObjectsWithTag("Wall"))
            {
                var renderer = wall.GetComponent<Renderer>();
                renderer.material = Resources.Load<Material>("Wall/wall11");
            }
        }

        public override void PaintCharacters()
        {
            GameObject.Find("Pacman!").GetComponent<Renderer>().material = Resources.Load<Material>("Yellow_Dark");
        }
    }
}