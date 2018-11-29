using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18transportCost
{
    class Program
    {
        static void Main(string[] args)
        {
            double km = double.Parse(Console.ReadLine());
            string dayOrnight = Console.ReadLine();
            double cost = 0;
            switch (dayOrnight)
            {
                case "day":
                    if (km <= 10)
                    {
                        cost = 0.70 + 0.79 * km;
                    }
                    else if (km >= 20)
                    {
                        cost = 0.09 * km;
                    }
                    else if (km > 100)
                    {
                        cost = 0.06 * km;
                    }


                    break;
                case "night":
                    if (km <= 10)
                    {
                        cost = 0.70 + 0.90 * km;
                    }
                    else if (km <= 20)
                    {
                        cost = 0.09 * km;
                    }
                    else if (km > 100)
                    {
                        cost = 0.06 * km;
                    }

                    break;
            }
            Console.WriteLine($"{cost:f2}");
        }
    }
}
