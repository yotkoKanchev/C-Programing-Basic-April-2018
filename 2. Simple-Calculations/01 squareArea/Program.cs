using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());

            double sqArea = a * a;
            Console.Write("Square = ");
            Console.WriteLine(sqArea);
        }
    }
}
