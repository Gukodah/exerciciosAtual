using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ex1
{
    class Exercicio2
    {
        public double discountsFivePercentFiveTimes(double value)
        {
            var watch = Stopwatch.StartNew();

            for (int i = 0; i < 5; i++)
            {
                value -= (value * 0.05);
            }

            watch.Stop();
            Console.WriteLine($"Time tooked: {watch.ElapsedMilliseconds} ms");

            return value;
        }
    }
}
