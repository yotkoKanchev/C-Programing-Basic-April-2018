using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number0to100text
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string one = "one";
            string two = "two";
            string three = "three";
            string four = "four";
            string five = "five";
            string six = "six";
            string seven = "seven";
            string eight = "eight";
            string nine = "nine";
            string zero = "zero";
            string twenty = "twenty";
            string thirty = "thirty";
            string forty = "forty";
            string fifty = "fifty";
            string sixty = "sixty";
            string seventy = "seventy";
            string eighty = "eighty";
            string ninety = "ninety";

            int oldThens = n / 10;
            int oldOnes = n % 10;

            string thens = "";
            string ones = "";
            if (n == 100)
            {
                Console.WriteLine("one hundred");
                return;
            }
            else if (n == 0)
            {
                Console.WriteLine("zero");
                return;
            }
            else if (n == 10)
            {
                Console.WriteLine("ten");
                return;
            }
            else if (n == 11)
            {
                Console.WriteLine("eleven");
            }
            else if (n == 12)
            {
                Console.WriteLine("twelve");
            }
            else if (n == 13)
            {
                Console.WriteLine("thirteen");
            }
            else if (n == 14)
            {
                Console.WriteLine("fourteen");
            }
            else if (n == 15)
            {
                Console.WriteLine("fifteen");
            }
            else if (n == 16)
            {
                Console.WriteLine("sixteen");
            }
            else if (n == 17)
            {
                Console.WriteLine("seventeen");
            }
            else if (n == 18)
            {
                Console.WriteLine("eighteen");
            }
            else if (n == 19)
            {
                Console.WriteLine("nineteen");
            }
            if (oldThens == 2)
            {
                thens = twenty;
            }
            else if (oldThens == 3)
            {
                thens = thirty;
            }
            else if (oldThens == 4)
            {
                thens = forty;
            }
            else if (oldThens == 5)
            {
                thens = fifty;
            }
            else if (oldThens == 6)
            {
                thens = sixty;
            }
            else if (oldThens == 7)
            {
                thens = seventy;
            }
            else if (oldThens == 8)
            {
                thens = eighty;
            }
            else if (oldThens == 9)
            {
                thens = ninety;
            }

            if (oldOnes == 1)
            {
                ones = one;
            }
            else if (oldOnes == 2)
            {
                ones = two;
            }
            else if (oldOnes == 3)
            {
                ones = three;
            }
            else if (oldOnes == 4)
            {
                ones = four;
            }
            else if (oldOnes == 5)
            {
                ones = five;
            }
            else if (oldOnes == 6)
            {
                ones = six;
            }
            else if (oldOnes == 7)
            {
                ones = seven;
            }
            else if (oldOnes == 8)
            {
                ones = eight;
            }
            else if (oldOnes == 9)
            {
                ones = nine;
            }

            if (n >= 0 && n <= 100)
            {
                if (oldOnes == 0)
                {
                    Console.WriteLine(thens);
                }
                if (n < 10)
                {
                    Console.WriteLine(ones);
                }

                if (oldOnes != 0 && oldThens != 0 && n > 20 && n < 100)
                {
                    Console.WriteLine($"{thens} {ones}");
                }
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
        }
    }
}
