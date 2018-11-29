using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double rows = double.Parse(Console.ReadLine());
            double cols = double.Parse(Console.ReadLine());

            double numSeats = rows * cols;
            double result = 0;

            switch (type)
            {
                case "Premiere":
                    result = numSeats * 12;
                    break;
                case "Normal":
                    result = numSeats * 7.50;
                    break;
                case "Discount":
                    result = numSeats * 5;
                    break;
            }
            Console.WriteLine($"{result:f2} leva");
        }
    }
}
