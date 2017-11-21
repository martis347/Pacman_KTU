namespace Assets.Scripts.Patterns.Interpreter
{
    public class DirectionExpression: AbstractExpression
    {
        public override void Interpret(Context context)
        {
            var directionLetter = context.GetFirstInputSymbol();
            Direction direction;
            switch (directionLetter)
            {
                case 'w':
                    direction = Direction.Forward;
                    break;
                case 's':
                    direction = Direction.Backwards;
                    break;
                case 'a':
                    direction = Direction.Right;
                    break;
                case 'd':
                    direction = Direction.Left;
                    break;
                default:
                    direction = Direction.None;
                    break;
            }

            if (direction == Direction.None)
            {
                return;
            }

            context.CutFirstSymbol();
            context.Pacman.SetDirection(direction);
        }
    }
}