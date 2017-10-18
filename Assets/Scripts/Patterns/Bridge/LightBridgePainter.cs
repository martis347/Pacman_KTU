using UnityEngine;

namespace Assets.Scripts.Patterns.Bridge
{
    public class LightBridgePainter : BridgePainter
    {
        public override void PaintBackground()
        {
            var camera = GameObject.Find("PacmanCamera").GetComponent<Camera>();
            camera.clearFlags = CameraClearFlags.SolidColor;
            camera.backgroundColor = Color.Lerp(Color.white, Color.white, 15);
        }

        public override void PaintWalls()
        {
            foreach (var wall in GameObject.FindGameObjectsWithTag("Wall"))
            {
                var renderer = wall.GetComponent<MeshRenderer>();
                renderer.material = Resources.Load<Material>("Wall/wall11b");
            }
        }

        public override void PaintCharacters()
        {
            var pacman = GameObject.Find("Pacman!");
            pacman.GetComponent<Renderer>().material = Resources.Load<Material>("Yellow");
        }
    }
}