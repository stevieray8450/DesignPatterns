namespace Visitor
{
    public class Employee : Element
    {
        public string Name { get; set; }
        public decimal Income { get; set; }
        public int VacationDays { get; set; }

        public override void Accept (IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}