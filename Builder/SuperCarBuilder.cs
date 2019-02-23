namespace Builder
{
    // The other "Concrete Class"
    public class SuperCarBuilder : CarBuilder
    {
        public override void SetHorsePower()
        {
            _car.HorsePower = 1640;
        }

        public override void SetTopSpeed()
        {
            _car.TopSpeedMPH = 600;
        }

        public override void SetImpressiveFeature()
        {
            _car.MostImpressiveFeature = "Can fly";
        }
    }
}