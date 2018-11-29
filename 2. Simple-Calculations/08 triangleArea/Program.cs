using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float h = float.Parse(Console.ReadLine());

            float area = a * h / 2;
            Console.WriteLine($"Triangle area = {Math.Round(area, 2)}");
            
        }
    }
}
