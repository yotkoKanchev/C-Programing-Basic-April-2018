using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20sleepyCatTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());

            int totalMinutes = holidays * 127 + (365 - holidays) * 63;

            if (totalMinutes >= 30000)
            {
                int diff = totalMinutes - 30000;
                int hours = diff / 60 ;
                int minutes = diff % 60 ;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                int diff = 30000 - totalMinutes;
                int hours = diff / 60;
                int minutes = diff % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
