using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20devidingWithNoRest
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    p1 += 1;
                }
                if (num % 3 == 0)
                {
                    p2 += 1;
                }
                if (num % 4 == 0)
                {
                    p3 += 1;
                }
            }
            Console.WriteLine($"{(100 / n * p1):f2}%");
            Console.WriteLine($"{(100 / n * p2):f2}%");
            Console.WriteLine($"{(100 / n * p3):f2}%");
        }
    }
}
