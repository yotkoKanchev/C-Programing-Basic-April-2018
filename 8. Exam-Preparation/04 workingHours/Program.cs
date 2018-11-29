using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04workingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            double hoursNeeded = double.Parse(Console.ReadLine());
            double workersNumber = double.Parse(Console.ReadLine());
            double workingDays = double.Parse(Console.ReadLine());

            double workingHours = workersNumber * workingDays * 8;

            double diff = Math.Abs(hoursNeeded - workingHours);

            if (hoursNeeded<= workingHours)
            {
                Console.WriteLine($"{diff} hours left");
            }
            else
            {
                Console.WriteLine($"{diff} overime");
                Console.WriteLine($"Penalties: {diff * workingDays}");
            }

        }
    }
}
