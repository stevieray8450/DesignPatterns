using System;

namespace Composite
{
    class Program
    {
        // CLIENT
        static void Main(string[] args)
        {
            var emp1 = new Employee 
             {
                EmployeeId = 1,
                Name = "Ricky",
                Rating = 3
            };

            var emp2 = new Employee 
            {
                EmployeeId = 2,
                Name = "Mike",
                Rating = 2
            };

            var super = new Supervisor 
            {
                EmployeeId = 3,
                Name = "Boss",
                Rating = 5
            };

            var super2 = new Supervisor 
            {
                EmployeeId = 4,
                Name = "Bobby",
                Rating = 1
            };

            super.AddSubordinate(emp1);
            super2.AddSubordinate(emp2);

            super.PerformanceSummary();
            
            foreach(var e in super.Subordinates)
            {
                e.PerformanceSummary();
            }
        }
    }
}
