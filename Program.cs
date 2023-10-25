using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvodnaVjezba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 7;

            double c = 12.5;
            double d = 16.7;

            Console.WriteLine("Prosjecna vrijednost od {0}, {1}, {2}, {3} je {4}", a, b, c, d, (a + b + c + d) / 4);

            Console.ReadKey();
        }
    }
}
