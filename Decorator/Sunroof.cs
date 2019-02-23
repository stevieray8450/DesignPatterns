namespace Decorator
{
    public class Sunroof : CarDecorator
    {
        public Sunroof(Car car) : base(car)
        {
            Description = "Sun roof";
        }

        public override string GetDescription() => $"{_car.GetDescription()}, {Description}";

        public override decimal GetPrice() => _car.GetPrice() + 3000.00m;
    }
}