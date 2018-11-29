using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21smartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            double loundryPrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            double bDayMoney = 0;
            double money = 0;
            double toyCount = 0;
            double brotherMoney = 0;
            
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    bDayMoney += 10;
                    money += bDayMoney;
                    brotherMoney += 1;
                }
                else
                {
                    toyCount += 1;
                }
            }
            double totalMoney = money - brotherMoney + toyCount * toyPrice;

            if (totalMoney>=loundryPrice)
            {
                Console.WriteLine($"Yes! {(totalMoney-loundryPrice):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(loundryPrice-totalMoney):f2}");
            }
        }
    }
}
