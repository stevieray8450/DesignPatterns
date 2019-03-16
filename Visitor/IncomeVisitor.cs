namespace Visitor
{
    public class IncomeVisitor : IVisitor
    {
        public void Visit (Element element)
        {
            var employee = element as Employee;

            employee.Income *= 1.10m;
            var moneyFormat = "{0:#.00}";
            System.Console.WriteLine($"{employee.Name}\'s new income is: {string.Format(moneyFormat, employee.Income)}");
        }
    }
}