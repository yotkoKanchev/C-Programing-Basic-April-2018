using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            double wineryM2 = double.Parse(Console.ReadLine());
            double grapePerM2 = double.Parse(Console.ReadLine());
            double wineInLittersNeeded = double.Parse(Console.ReadLine());
            double workersNumber = double.Parse(Console.ReadLine());

            double areaForWine = 0.4 * wineryM2;
            double totalGrapeForWine = areaForWine * grapePerM2;
            double wineProduced = totalGrapeForWine / 2.5;

            if (wineProduced < wineInLittersNeeded)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineInLittersNeeded - wineProduced)} liters wine needed.”");
            }
            else
            {
                double winePerWorker = (wineProduced - wineInLittersNeeded) / workersNumber;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineProduced)} liters");
                Console.WriteLine($"{Math.Ceiling(wineProduced-wineInLittersNeeded)} liters left -> {Math.Ceiling(winePerWorker)} liters per person.");
            }
        }
    }
}
