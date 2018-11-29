using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_05___Пеперуда
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numberOfstars = 0;
            string stars = new string ('*', n - 2);
            string middle = "\\ /";
            string dashes = new string('-', n - 2);

            Console.WriteLine(stars + middle + stars);

            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine(dashes + middle + dashes);
                Console.WriteLine(stars + middle + stars);
            }

            string emptySpaces = new string(' ', n - 1);
            Console.WriteLine(emptySpaces + '@');

            middle = "/ \\";

            for (int i = 0; i < n / 2 - 1; i++)
            {               
                Console.WriteLine(stars + middle + stars);
                Console.WriteLine(dashes + middle + dashes);                
            }

            Console.WriteLine(stars + middle + stars);
        }
    }
}
