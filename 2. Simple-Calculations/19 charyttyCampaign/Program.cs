using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19charyttyCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double chefs = double.Parse(Console.ReadLine());
            double cakes = double.Parse(Console.ReadLine());
            double gofrets = double.Parse(Console.ReadLine());
            double pancakes = double.Parse(Console.ReadLine());

            double totalMoney = days * chefs * (cakes * 45 + gofrets * 5.80 + pancakes * 3.20);
            double moneyLeft = totalMoney - totalMoney / 8;

            Console.WriteLine($"{moneyLeft:f2}");

        }
    }
}
