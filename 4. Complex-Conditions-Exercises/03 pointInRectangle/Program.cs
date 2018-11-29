using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03pointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            string result = "";
            if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
            {
                result = "Inside";
            }
            else
            {
                result = "Outside";
            }
            Console.WriteLine(result);
        }
    }
}
