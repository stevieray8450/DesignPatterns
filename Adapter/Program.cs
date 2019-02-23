using System;

namespace Adapter
{
    class Program
    {
        // the "Client"
        static void Main(string[] args)
        {
            Console.WriteLine("Third party employees: ");
            
            // use the ITarget interface to functionality of "Adaptee" class
            var adapter = new EmployeeAdapter();
            adapter.GetEmployees().ForEach(Console.WriteLine);
        }
    }
}
