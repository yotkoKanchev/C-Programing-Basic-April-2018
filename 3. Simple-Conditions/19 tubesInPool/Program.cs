using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19tubesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume = double.Parse(Console.ReadLine());
            double firstTubeDebtPerHour = double.Parse(Console.ReadLine());
            double secondTubeDebtPerHour = double.Parse(Console.ReadLine());
            double workingHours = double.Parse(Console.ReadLine());

            double totalLitters = (firstTubeDebtPerHour + secondTubeDebtPerHour) * workingHours;
            double firstTubePercentige = 100 / totalLitters * firstTubeDebtPerHour * workingHours;
            double secondTubePercentige = 100 / totalLitters * secondTubeDebtPerHour * workingHours;

            double percentigeOfVolume = 100 / volume * totalLitters;
            if (totalLitters <= volume)
            {
                Console.WriteLine($"The pool is {percentigeOfVolume}% full. Pipe 1: {Math.Floor(firstTubePercentige)}%. Pipe 2: {Math.Floor(secondTubePercentige)}%.");
            }
            else
            {
                Console.WriteLine($"For {workingHours} hours the pool overflows with {(totalLitters-volume):f1} liters.");
            }
        }
    }
}
