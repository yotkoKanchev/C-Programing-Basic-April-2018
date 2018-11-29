using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03stereopor
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double houseArea = double.Parse(Console.ReadLine());
            double windowsNumber = double.Parse(Console.ReadLine());
            double m2stereoporInPackage = double.Parse(Console.ReadLine());
            double packegePrice = double.Parse(Console.ReadLine());

            double stereoporNeeded = 1.1 * (houseArea - windowsNumber * 2.4);
            double packegesNeeded = Math.Ceiling(stereoporNeeded / m2stereoporInPackage);
            double money = packegesNeeded * packegePrice;
            double diff = Math.Abs(budget - money);
            if (budget >= money)
            {
                Console.WriteLine($"Spent: {money:f2}");
                Console.WriteLine($"Left: {diff:f2}");
            }
            else
            {
                Console.WriteLine($"Need more: {diff:f2}");
            }


        }
    }
}
