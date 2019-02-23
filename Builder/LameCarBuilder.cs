namespace Builder
{
    // The "Concrete Builder" class
    public class LameCarBuilder : CarBuilder
    {
        public override void SetHorsePower()
        {
            // _car is protected, not public/private
            _car.HorsePower = 120;
        }

        public override void SetTopSpeed()
        {
            _car.TopSpeedMPH = 80;
        }

        public override void SetImpressiveFeature()
        {
            _car.MostImpressiveFeature = "A/C";
        }
    }
}