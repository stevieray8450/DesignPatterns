using System.Collections.Generic;

namespace Visitor
{
    public class Employees
    {
        public List<Employee> EmployeesList = new List<Employee> ();

        public void Accept (IVisitor visitor) 
        { 
            foreach(var e in EmployeesList)
            {
                e.Accept(visitor);
            }
            System.Console.WriteLine();
        }
    }
}