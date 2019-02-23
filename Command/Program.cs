using System;

namespace Command
{
    // command pattern is commonly used in menu scenarios (editors, IDEs)
    // whenever you need a request wrapped under an object,
    // you can use this pattern to have that object used as a command that can be passed
    // to an invoker object
    class Program
    {
        static void Main(string[] args)
        {
            // Create User and let them compute
            var user = new User();

            // User presses the calculator buttons
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // Undo 4 commands
            user.Undo(4);

            // Redo 3 commands
            user.Redo(3);

            // Wait for user
            Console.ReadKey();
        }
    }
}
