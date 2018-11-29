using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberOfStars = 0;
            string stars = "";
            if (n % 2 == 0)
            {
                stars = new string('*', 2);
                numberOfStars = 2;
            }
            else
            {
                stars = new string('*', 1);
                numberOfStars = 1;
            }

            int leftRightDashes = (n - numberOfStars) / 2;
            string dashes = new string('-', leftRightDashes);

            Console.WriteLine(dashes + stars + dashes);

            for (int i = 0; i < (n - 1) / 2; i++)
            {
                leftRightDashes -= 1;

                if (leftRightDashes > 0)
                {
                    dashes = new string('-', leftRightDashes);
                    numberOfStars = n - (2 * leftRightDashes);
                    stars = new string('*', numberOfStars);
                    Console.WriteLine(dashes + stars + dashes);
                }

                else
                {
                    numberOfStars = n;
                    stars = new string('*', numberOfStars);
                    Console.WriteLine(stars);
                }              
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(('|') + new string('*', n - 2) + '|');
            }
        }
    }
}
