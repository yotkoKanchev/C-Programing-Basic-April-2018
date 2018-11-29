using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05flowersShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double chrisNumber = double.Parse(Console.ReadLine());
            double rosesNumber = double.Parse(Console.ReadLine());
            double tulipsNumber = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holidayOrNo = Console.ReadLine();

            double flowersNumber = chrisNumber + rosesNumber + tulipsNumber;

            double chrisMoney = 0;
            double rosesMoney = 0;
            double tulipsMoney = 0;
            
            if (season == "Spring" || season == "Summer")
            {
                chrisMoney = chrisNumber * 2;
                rosesMoney = rosesNumber * 4.10;
                tulipsMoney = tulipsNumber * 2.50;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                chrisMoney = chrisNumber * 3.75;
                rosesMoney = rosesNumber * 4.50;
                tulipsMoney = tulipsNumber * 4.15;
            }
            double totalMoney = 0;
            if (holidayOrNo == "Y")
            {
                totalMoney = 1.15 * (chrisMoney + rosesMoney + tulipsMoney);
            }
            else
            {
                totalMoney = chrisMoney + rosesMoney + tulipsMoney; ;
            }

            if (season == "Spring")
                {
                    if (tulipsNumber > 7)
                    {
                        totalMoney = totalMoney * 0.95;
                    }
                }
                else if (season == "Winter")
                {
                    if (rosesNumber > 9)
                    {
                        totalMoney = totalMoney * 0.9;
                    }
                }
            if (flowersNumber > 20)
            {
                totalMoney = totalMoney * 0.8;
            }    
            Console.WriteLine($"{(2 + totalMoney):f2}");
        }
    }
}
