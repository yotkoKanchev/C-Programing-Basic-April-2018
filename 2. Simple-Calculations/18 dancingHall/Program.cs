using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18dancingHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());

            double clearHallAreaCm2 = l * w * 10000 * 0.9 - (a*a * 10000);
            double dancers = clearHallAreaCm2 / 7040;

            Console.WriteLine($"{Math.Floor(dancers)}");
        }
    }
}
