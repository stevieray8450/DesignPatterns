using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Car theCar = new CompactCar();
            theCar = new Sunroof(theCar);

            Console.WriteLine(theCar.GetDescription());
            Console.WriteLine(theCar.GetPrice());
        }
    }
}
