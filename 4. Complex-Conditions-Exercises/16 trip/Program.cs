using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            double money = 0;
            string accomodationType = "";
            switch (season)
            {
                case "summer":
                    
                    if (budget > 0 && budget <= 100)
                    {
                        destination = "Bulgaria";
                        money = budget * 0.3;
                        accomodationType = "Camp";
                    }
                    else if (budget <= 1000)
                    {
                        destination = "Balkans";
                        money = budget * 0.4;
                        accomodationType = "Camp";
                    }
                    else if (budget > 1000)
                    {
                        destination = "Europe";
                        money = budget * 0.9;
                        accomodationType = "Hotel";
                    }
                    break;
                case "winter":
                    accomodationType = "Hotel";
                    if (budget > 0 && budget <= 100)
                    {
                        destination = "Bulgaria";
                        money = budget * 0.7;
                    }
                    else if (budget <= 1000)
                    {
                        destination = "Balkans";
                        money = budget * 0.8;
                    }
                    else if (budget > 1000)
                    {
                        destination = "Europe";
                        money = budget * 0.9;
                    }
                    break;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{accomodationType} - {money:f2}");
        }
    }
}
