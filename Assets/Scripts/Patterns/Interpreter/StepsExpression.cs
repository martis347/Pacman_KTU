using System;

namespace Assets.Scripts.Patterns.Interpreter
{
    public class StepsExpression: AbstractExpression
    {
        public override void Interpret(Context context)
        {
            var stepsToTake = (int) Char.GetNumericValue(context.GetFirstInputSymbol());
            if (stepsToTake == -1)
            {
                return;
            }
            context.CutFirstSymbol();
            context.Pacman.MoveSteps(stepsToTake);
        }
    }
}