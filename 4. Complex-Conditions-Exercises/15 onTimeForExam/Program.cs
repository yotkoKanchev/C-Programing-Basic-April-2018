using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15onTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int totalExamMinutes = examHour * 60 + examMinutes;
            int totalArrivalMinutes = arrivalHour * 60 + arrivalMinutes;

            int diffMinutes = totalArrivalMinutes - totalExamMinutes;
            if (diffMinutes == 0)
            {
                Console.WriteLine("On time");
            }

            else if (diffMinutes > 0 && diffMinutes < 60)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{diffMinutes:d2} minutes after the start");
            }
            else if (diffMinutes > 59)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{diffMinutes / 60}:{diffMinutes % 60:d2} hours after the start");
            }
            else if (diffMinutes < 0 && diffMinutes > -31)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{Math.Abs(diffMinutes)} minutes before the start");
            }
            else if (diffMinutes < -30)
            {
                Console.WriteLine("Early");
                if (diffMinutes > -60)
                {
                    Console.WriteLine($"{Math.Abs(diffMinutes)} minutes before the start");
                }
                if (diffMinutes < -59)
                {
                    Console.WriteLine($"{ Math.Abs(diffMinutes/60)}:{Math.Abs(diffMinutes%60):d2} hours before the start");
                }
            }

        }
    }
}
