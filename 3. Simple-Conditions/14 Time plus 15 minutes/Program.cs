using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (hours < 23 & minutes <= 44)
            {
                Console.WriteLine(hours + ":" + (minutes + 15));
            }

            else if (hours <23 & minutes >= 45 & minutes <= 54)
            {
                Console.WriteLine((hours + 1) + ":0" + (minutes + 15 - 60));
            }

            else if (hours < 23 & minutes >= 55)
            {
                Console.WriteLine((hours + 1) + ":" + (minutes + 15 - 60));
            }

            else if (hours == 23 & minutes <= 44)
            {
                Console.WriteLine(hours + ":" + (minutes + 15));
            }

            else if (hours == 23 & minutes >= 45 & minutes <= 54)
            {
                Console.WriteLine("0:0" + (minutes + 15 - 60));
            }

            else if (hours == 23 & minutes >= 55)
            {
                Console.WriteLine("0:" + (minutes + 15 - 60));
            }




        }
    }
}
