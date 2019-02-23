using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var nyt = new NYPaper();
            var lat = new LAPaper();

            IIterator nytIterator = nyt.CreateIterator();
            IIterator latIterator = lat.CreateIterator();

            System.Console.WriteLine("NYT Paper reporters: ");
            PrintReporters(nytIterator);

            System.Console.WriteLine("LAT Paper reporters: ");
            PrintReporters(latIterator);
        }

        static void PrintReporters(IIterator iterator)
        {
            while(!iterator.IsDone())
            {
                System.Console.WriteLine(iterator.Next());
            }
        }
    }
}
