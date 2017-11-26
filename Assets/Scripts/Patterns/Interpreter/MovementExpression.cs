namespace Assets.Scripts.Patterns.Interpreter
{
    public class MovementExpression: AbstractExpression
    {
        private readonly AbstractExpression stepsExpression;
        private readonly AbstractExpression directionExpression;
        public MovementExpression(AbstractExpression stepsExpression, AbstractExpression directionExpression)
        {
            this.stepsExpression = stepsExpression;
            this.directionExpression = directionExpression;
        }

        public override void Interpret(Context context)
        {
            directionExpression.Interpret(context);
            stepsExpression.Interpret(context);
        }
    }
}