using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            double weekends = double.Parse(Console.ReadLine());

            double games = 0;
            switch (year)
            {
                case "leap":
                    games = 1.15 * (weekends + (48 - weekends) * 3 / 4 + holidays * 2 / 3);
                    break;
                case "normal":
                    games = weekends + (48 - weekends) * 3 / 4 + holidays * 2 / 3;
                    break;
            }
            Console.WriteLine($"{Math.Floor(games)}");
        }
    }
}
