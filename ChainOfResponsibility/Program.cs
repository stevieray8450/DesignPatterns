using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dir = new Director();
            var vice = new VicePresident();
            dir.SetSuccessor(vice);
            var pres = new President();
            vice.SetSuccessor(pres);

            var expense = new Purchase { Number = 1, Amount = 45000.0m };
            dir.ProcessRequest(expense);
        }
    }
}
