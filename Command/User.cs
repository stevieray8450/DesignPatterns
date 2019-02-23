using System.Collections.Generic;

namespace Command
{
    // the 'invoker' class
    public class User
    {
        private Calculator _calculator = new Calculator();
        private List<Command> _commands = new List<Command>();
        private int _current = 0;

        public void Redo(int levels)
        {
            System.Console.WriteLine("\n---- Redo {0} levels ", levels);

            for (int i = 0; i < levels; i++)
            {
                if (_current < _commands.Count - 1)
                {
                    var command = _commands[_current++];
                    command.Execute();
                }
            }
        }

        public void Undo(int levels)
        {
            System.Console.WriteLine("\n---- Undo {0} levels", levels);

            for (int i = 0; i < levels; i++)
            {
                if (_current > 0)
                {
                    var command = _commands[--_current];
                    command.Unexecute();
                }
            }
        }

        public void Compute(char @operator, int operand)
        {
            var command = new CalculatorCommand(_calculator, @operator, operand);
            command.Execute();

            // adds command to undo list
            _commands.Add(command);
            _current++;
        }
    }
}