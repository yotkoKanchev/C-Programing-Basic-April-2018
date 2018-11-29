using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07furitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;
            double result = 0;

            string weekendOrNot = "";
            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                weekendOrNot = "weekday";
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                weekendOrNot = "weekend";
            }

            if (weekendOrNot == "weekday")
            {
                if (fruit == "banana")
                {
                    price = 2.50;
                }
                else if (fruit == "apple")
                {
                    price = 1.20;
                }
                else if (fruit == "orange")
                {
                    price = 0.85;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.45;
                }
                else if (fruit == "kiwi")
                {
                    price = 2.70;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.50;
                }
                else if (fruit == "grapes")
                {
                    price = 3.85;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (weekendOrNot == "weekend")
            {
                if (fruit == "banana")
                {
                    price = 2.70;
                }
                else if (fruit == "apple")
                {
                    price = 1.25;
                }
                else if (fruit == "orange")
                {
                    price = 0.90;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.60;
                }
                else if (fruit == "kiwi")
                {
                    price = 3.00;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.60;
                }
                else if (fruit == "grapes")
                {
                    price = 4.20;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            
            result = quantity * price;
            Console.WriteLine($"{result:f2}");
        }
    }
}
