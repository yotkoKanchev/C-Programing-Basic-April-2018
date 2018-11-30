using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter even number:");

                int num = 0;

                bool isInteger = int.TryParse(Console.ReadLine(), out num);

                if (isInteger)
                {
                    if (num % 2 == 0)
                    {
                        Console.WriteLine($"Even number entered: {num}");
                        break;
                    }
                    Console.WriteLine("The number is not even.");
                }

                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
    }
}
