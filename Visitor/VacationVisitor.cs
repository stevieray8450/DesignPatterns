namespace Visitor
{
    public class VacationVisitor : IVisitor
    {
        public void Visit (Element element)
        {
            var employee = element as Employee;

            employee.VacationDays += 3;
            System.Console.WriteLine($"{employee.Name}\'s new amount of vacation days is: {employee.VacationDays}");
        }
    }
}