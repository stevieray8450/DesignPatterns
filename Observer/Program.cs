using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var fanA = new Fan();
            fanA.Name = "Steve";
            var fanB = new Fan();
            fanB.Name = "George";

            var celeb1 = new Celebrity();
            celeb1.Fans = new List<IFan> { fanA, fanB };
            celeb1.Name = "George Clooney";

            celeb1.Tweet = "Hello World!";
        }
    }
}
