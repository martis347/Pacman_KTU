namespace Assets.Scripts.Patterns.Bridge
{
    public abstract class BridgePainter
    {
        public abstract void PaintBackground();
        public abstract void PaintWalls();
        public abstract void PaintCharacters();
    }
}