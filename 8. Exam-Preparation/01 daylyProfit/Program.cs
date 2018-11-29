using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01daylyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            double workDays = double.Parse(Console.ReadLine());
            double moneyPerDay = double.Parse(Console.ReadLine());
            double exchangeRateUsdBgn = double.Parse(Console.ReadLine());

            Console.WriteLine($"{((workDays * moneyPerDay * 14.5 * 0.75 * exchangeRateUsdBgn) / 365):f2}");


        }
    }
}
