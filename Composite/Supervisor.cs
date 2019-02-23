using System.Collections.Generic;

namespace Composite
{
    // "Composite" class -- will be branch node in tree structure
    public class Supervisor : IEmployee
    {
        public int EmployeeId {get;set;}
        public string Name {get;set;}
        public int Rating {get;set;}

        public List<IEmployee> Subordinates = new List<IEmployee>();
        public void PerformanceSummary()
        {
            System.Console.WriteLine("Performance was fine");
        }

        public void AddSubordinate(IEmployee employee)
        {
            Subordinates.Add(employee);
        }
    }
}