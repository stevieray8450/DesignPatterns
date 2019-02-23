namespace Builder
{
    // The "Director" Class
    public class CarFactory
    {
        public Car Build(CarBuilder carBuilder)
        {
            carBuilder.SetHorsePower();
            carBuilder.SetImpressiveFeature();
            carBuilder.SetTopSpeed();
            return carBuilder.GetCar();
        }
    }
}