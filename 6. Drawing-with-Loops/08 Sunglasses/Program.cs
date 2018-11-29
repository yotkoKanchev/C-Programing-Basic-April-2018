using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', n * 2) + new string(' ', n) + new string('*', n * 2));

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("*");
                Console.Write(new string('/', n * 2 - 2));
                Console.Write("*");

                if (i == (n - 1) / 2 - 1)
                {
                    Console.Write(new string('|', n));
                }

                else
                {
                    Console.Write(new string(' ', n));
                }
            }

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("*");
                Console.Write(new string('/', n * 2 - 2));
                Console.Write("*");
                Console.WriteLine();
            }
            
            Console.WriteLine(new string('*', n * 2) + new string(' ', n) + new string('*', n * 2));
        }
    }
}
