using System.Collections.Generic;

namespace Adapter
{
    // the 'Adaptee' class
    public class ThirdPartyEmployee
    {   
        public List<string> GetEmployeeList()
        {
            List<string> employeeList = new List<string>();
            employeeList.Add("Peter");
            employeeList.Add("Paul");
            employeeList.Add("Puru");
            employeeList.Add("Preethi");
            return employeeList;
        }
    }
}