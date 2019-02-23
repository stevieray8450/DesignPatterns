namespace Decorator
{
    public class CarDecorator : Car
    {
        protected Car _car;
        public CarDecorator(Car car)
        {
            _car = car;
        }

        public override string GetDescription() => _car.GetDescription();
        public override decimal GetPrice() => _car.GetPrice();
    }
}