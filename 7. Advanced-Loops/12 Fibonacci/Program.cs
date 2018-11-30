using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int fib1 = 1;
            int fib2 = 1;

            for (int i = 1; i < n; i++)
            {
                int fibNext = fib1 + fib2;
                fib1 = fib2;
                fib2 = fibNext;
            }
            Console.WriteLine(fib2);
        }
    }
}
