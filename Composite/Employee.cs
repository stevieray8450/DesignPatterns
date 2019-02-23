namespace Composite
{

    // "leaf" class - will be "node" in tree structure
    public class Employee : IEmployee
    {
        public int EmployeeId {get;set;}
        public string Name {get;set;}
        public int Rating {get;set;}
        public void PerformanceSummary()
        {
            System.Console.WriteLine($"Performance summary: {Name} is {Rating}");
        }
    }
}