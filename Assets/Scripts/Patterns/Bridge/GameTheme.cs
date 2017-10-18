namespace Assets.Scripts.Patterns.Bridge
{
    public abstract class GameTheme
    {
        protected BridgePainter Implementor;

        public BridgePainter BridgePainter
        {
            set { Implementor = value; }
        }
        public abstract void SetGameBackgroundColor();
        public abstract void SetWallsColor();
        public abstract void SetFloorColor();
    }
}
