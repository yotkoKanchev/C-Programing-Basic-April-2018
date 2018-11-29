using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14birthDay
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double procentidge = double.Parse(Console.ReadLine());

            double volume = lenght * width * height;
            double litters = (volume * 0.001) * (100 - procentidge)/100;

            Console.WriteLine($"{litters:f3}");
        }
    }
}
