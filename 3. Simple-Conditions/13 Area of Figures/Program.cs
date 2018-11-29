using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"{side * side:F3}");
            }

            if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * b:F3}");                
            }

            if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.PI * r * r:F3}");
            }

            if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(a * h) / 2:F3}");
            }


        }
    }
}
