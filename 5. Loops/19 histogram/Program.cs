using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (double i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1 += 1;
                }
                else if (num < 400)
                {
                    p2 += 1;
                }
                else if (num < 600)
                {
                    p3 += 1;
                }
                else if (num < 800)
                {
                    p4 += 1;
                }
                else if (num >= 800)
                {
                    p5 += 1;
                }
            }
            Console.WriteLine($"{(100/n * p1):f2}%");
            Console.WriteLine($"{(100/n * p2):f2}%");
            Console.WriteLine($"{(100/n * p3):f2}%");
            Console.WriteLine($"{(100/n * p4):f2}%");
            Console.WriteLine($"{(100/n * p5):f2}%");
        }
    }
}
