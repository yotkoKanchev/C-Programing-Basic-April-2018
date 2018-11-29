using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double degrees = radians * 180 / Math.PI;

            Console.WriteLine(Math.Round(degrees));
        }
    }
}
