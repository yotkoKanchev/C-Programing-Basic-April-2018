using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number100To200
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber < 100)
            {
                Console.WriteLine("Less than 100");
            }

            else if (inputNumber > 200)
            {
                Console.WriteLine("Greater than 200");
            }

            else
                Console.WriteLine("Between 100 and 200");
        }
    }
}
