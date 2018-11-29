using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inchesToCm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            double inches = double.Parse(Console.ReadLine());

            double inCm = inches * 2.54;

            Console.Write("Centimeters = ");
            Console.WriteLine(inCm);
        }
    }
}
