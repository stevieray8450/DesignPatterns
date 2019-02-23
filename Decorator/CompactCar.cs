namespace Decorator
{
    public class CompactCar : Car
    {
        public CompactCar()
        {
            Description = "Compact car";
        }

        public override string GetDescription() => Description;
        public override decimal GetPrice() => 10000.00m;
    }
}