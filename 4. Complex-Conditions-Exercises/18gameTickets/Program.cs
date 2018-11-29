using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18gameTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            double people = double.Parse(Console.ReadLine());
            double transportMoney = 0;
            if (people < 5)
            {
                transportMoney = 0.75 * budget;
            }
            else if (people < 10)
            {
                transportMoney = 0.6 * budget;
            }
            else if (people < 25)
            {
                transportMoney = 0.5 * budget;
            }
            else if (people < 50)
            {
                transportMoney = 0.4 * budget;
            }
            else if (people >= 50)
            {
                transportMoney = 0.25 * budget;
            }
            double moneyLeft = budget - transportMoney;
            double diff = 0;
            switch (category)
            {
                case "VIP":
                    diff = moneyLeft - (people * 499.99);
                    if (people * 499.99 <= moneyLeft)                        
                    {                        
                        Console.WriteLine($"Yes! You have {diff:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {Math.Abs(diff):f2} leva.");
                    }
                    break;
                case "Normal":
                    diff = moneyLeft - (people * 249.99);
                    if (people * 249.99 <= moneyLeft)
                    {                        
                        Console.WriteLine($"Yes! You have {diff:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {Math.Abs(diff):f2} leva.");
                    }
                    break;
            }

        }
    }
}
