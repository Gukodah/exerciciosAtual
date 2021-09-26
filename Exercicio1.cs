using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ex1
{
    class Exercicio1
    {
        public string reverse(string word)
        {
            var watch = Stopwatch.StartNew();

            string reversed = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }

            watch.Stop();
            Console.WriteLine($"Time tooked: {watch.ElapsedMilliseconds} ms");

            return reversed;

        }
    }
}
