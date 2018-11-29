using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayer = int.Parse(Console.ReadLine());
            int secondPlayer = int.Parse(Console.ReadLine());
            int thirdPlayer = int.Parse(Console.ReadLine());

            int totalSeconds = firstPlayer + secondPlayer + thirdPlayer;

            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            if (seconds > 9)
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }

            else
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }


        }
    }
}
