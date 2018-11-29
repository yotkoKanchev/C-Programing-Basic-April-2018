using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.alchoholSales
{
    class Program
    {
        static void Main(string[] args)
        {
            double wiskeyPrice = double.Parse(Console.ReadLine());
            double beerLitters = double.Parse(Console.ReadLine());
            double wineLitters = double.Parse(Console.ReadLine());
            double rakiaLitters = double.Parse(Console.ReadLine());
            double wiskeyLitters = double.Parse(Console.ReadLine());

            double rakiaPrice = wiskeyPrice * 0.5;
            double winePrice = rakiaPrice * 0.6;
            double beerPrice = rakiaPrice * 0.2;

            double totalMoney = beerLitters * beerPrice + wineLitters * winePrice + rakiaPrice * rakiaLitters + wiskeyPrice * wiskeyLitters;
            Console.WriteLine($"{totalMoney:f2}");
        }
    }
}
