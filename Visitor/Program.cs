using System;

namespace Visitor
{
    class Program
    {
        static void Main (string[] args)
        {
            var employees = new Employees ();

            var director = new Director { Name = "Steve", Income = 100000, VacationDays = 100 } as Employee;
            var president = new President { Name = "Bob", Income = 1000000, VacationDays = 10 } as Employee;
            var clerk = new Clerk { Name = "Mary", Income = 10000, VacationDays = 1 } as Employee;

            employees.EmployeesList.AddRange (new [] { director, president, clerk });

            var incomeVisitor = new IncomeVisitor ();
            var vacationDaysVisitor = new VacationVisitor ();

            employees.Accept(incomeVisitor);
            employees.Accept(vacationDaysVisitor);

        }
    }
}