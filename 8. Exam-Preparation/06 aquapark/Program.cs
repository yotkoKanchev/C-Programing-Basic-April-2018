using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06aquapark
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            double hours = double.Parse(Console.ReadLine());
            double people = double.Parse(Console.ReadLine());
            string partOfTheDay = Console.ReadLine().ToLower();

            double price = 0;
            if ((month == "march" || month == "april" || month == "may") && partOfTheDay == "day")
                {
                    price = 10.50;
                }
            else if ((month == "june" || month == "july" || month == "august") && partOfTheDay == "day")
                {
                    price = 12.60;
                }
           
            else if ((month == "march" || month == "april" || month == "may") && partOfTheDay == "night")
                {
                    price = 8.4;
                }
            else if ((month == "june" || month == "july" || month == "august") && partOfTheDay == "night")
                {
                    price = 10.20;
                }
                     
            if (people > 3)
            {
                price = price * 0.9;
            }

            if (hours >= 5)
            {
                price = price * 0.5;
            }

            double totalMoney = people * price*hours;

            Console.WriteLine($"Price per person for one hour: {price:f2}");
            Console.WriteLine($"Total cost of the visit: {totalMoney:f2}");

        }
    }
}
