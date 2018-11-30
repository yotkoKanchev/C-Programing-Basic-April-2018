using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Cat_Training_Attendance
{
    class Program
    {
        static void Main(string[] args)
        {
            double startingHour = double.Parse(Console.ReadLine());
            double checkInTimeHours = double.Parse(Console.ReadLine());
            double checkInTimeMinutes = double.Parse(Console.ReadLine());
            string dayOfTheweek = Console.ReadLine();

            double startingHoursInMinutes = startingHour * 60;
            double checkInTimeHoursInMinutes = checkInTimeHours * 60;
            double totalCheckInTimeInMinutes = checkInTimeHoursInMinutes + checkInTimeMinutes;

            double bonusPoints = 0;

            if (startingHoursInMinutes -totalCheckInTimeInMinutes > 0 && totalCheckInTimeInMinutes - startingHoursInMinutes <= 60)
            {
                bonusPoints = 1.5;
            }

            else if (totalCheckInTimeInMinutes - startingHoursInMinutes >= 0 && totalCheckInTimeInMinutes - startingHoursInMinutes <= 30)
            {
                bonusPoints = 1;
            }

            else if (totalCheckInTimeInMinutes - startingHoursInMinutes >= 30 && totalCheckInTimeInMinutes - startingHoursInMinutes <= 210)
            {
                bonusPoints = 0.5;
            }

            if (dayOfTheweek == "Monday" || dayOfTheweek == "Wednesday" || dayOfTheweek == "Friday")
            {
                bonusPoints += 0.6;
            }

            else if (dayOfTheweek == "Tuesday" || dayOfTheweek == "Thursday" || dayOfTheweek == "Saturday")
            {
                bonusPoints += 0.8;
            }

            else
            {
                bonusPoints += 2;
            }

            Console.WriteLine($"{bonusPoints:F2}");
        }
    }
}
