using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05invalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isValid = ((number >= 100 && number <= 200) || number == 0);

            if (!isValid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
