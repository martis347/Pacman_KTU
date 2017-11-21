using Assets.Scripts.Components;

namespace Assets.Scripts.Patterns.Interpreter
{
    public class Context
    {
        public PacmanComponent Pacman { get; private set; }
        private string input;

        public Context(PacmanComponent pacman, string input)
        {
            Pacman = pacman;
            this.input = input;
        }

        public void CutFirstSymbol()
        {
            input = input.Substring(1);
        }

        public char GetFirstInputSymbol()
        {
            return input[0];
        }

        public bool NotEmpty()
        {
            return input.Length > 1;
        }
    }
}