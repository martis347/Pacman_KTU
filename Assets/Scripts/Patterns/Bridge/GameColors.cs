namespace Assets.Scripts.Patterns.Bridge
{
    public class GameColors: GameTheme
    {
        public override void SetGameBackgroundColor()
        {
            Implementor.PaintBackground();
        }

        public override void SetWallsColor()
        {
            Implementor.PaintWalls();
        }

        public override void SetFloorColor()
        {
            Implementor.PaintCharacters();
        }
    }
}