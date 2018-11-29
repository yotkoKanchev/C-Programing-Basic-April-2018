using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15sewingFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            double tables = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double totalMoneySquares = tables * (lenght / 2) * (lenght / 2) ;
            double totalMoneyRectangles = tables * (lenght + 0.6) * (width + 0.6);
            double totalMoney = (totalMoneyRectangles * 7) + (9 * totalMoneySquares);
            Console.WriteLine($"{totalMoney:f2} USD");
            Console.WriteLine($"{totalMoney*1.85:f2} BGN");
        }
    }
}
