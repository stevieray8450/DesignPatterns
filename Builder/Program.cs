using System;

namespace Builder
{
    // The "Client"
    class Program
    {
        static void Main(string[] args)
        {
            var superCarBuilder = new SuperCarBuilder();
            var superCar = new CarFactory().Build(superCarBuilder);

            var lameCarBuilder = new LameCarBuilder();
            var lameCar = new CarFactory().Build(lameCarBuilder);

            // (could choose to put builders in a collection and iterate over each, calling .Build() on each)
        }
    }
}
