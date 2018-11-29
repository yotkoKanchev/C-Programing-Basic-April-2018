using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
                        
            int numberOfstorks = n / 2;
            string storks = new string('^',numberOfstorks);
            int numberOfdashes = (n + 1) / 2 - 2;
            string dashes = new string('_', numberOfdashes);
            Console.Write('/' + storks + '\\' + dashes);
            Console.WriteLine(dashes + '/' + storks + '\\');
            int numberOfEmptySpaces = n - 1;
            string emptySpaces = new string(' ', 2 * numberOfEmptySpaces);

            for (int i = 0; i < n - 3; i++)
            {                         
                Console.WriteLine('|' + emptySpaces + '|');
            }
            Console.WriteLine('|' + new string(' ', n / 2 + 1) + new string('_', numberOfdashes * 2) + new string(' ', n / 2 + 1) + '|');
            Console.WriteLine('\\' + new string('_', n / 2) + '/' + new string(' ', numberOfdashes * 2) + '\\' + new string('_', n / 2) + '/');

        }
    }
}
