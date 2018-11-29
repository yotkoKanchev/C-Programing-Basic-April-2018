using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double sideA = Math.Abs(x1 - x2);
            double sideB = Math.Abs(y1 - y2);

            double area = sideA * sideB;
            double perimeter = 2 * (sideA + sideB);
            Console.WriteLine(area);
            Console.WriteLine(perimeter);



        }
    }
}
