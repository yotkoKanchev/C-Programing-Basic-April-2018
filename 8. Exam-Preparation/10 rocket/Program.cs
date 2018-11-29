using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dots = (3 * n - 2)/2;
            int emptySpaces = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('.', dots) + '/' + new string(' ', emptySpaces) + '\\' + new string('.', dots));
                dots--;
                emptySpaces += 2;
            }
            dots += 1;
            Console.WriteLine(new string('.', dots) + new string('*', 3 * n - 2 * dots) + new string('.', dots));

            for (int i = 1; i <= 2 * n; i++)
            {
                Console.WriteLine(new string('.', dots) + '|' + new string('\\', 3 * n - 2 * dots - 2) + '|' +new string('.', dots));
            }

            dots = n / 2;
            int stars = 3 * n - 2 * dots - 2;
            for (int i = 1; i <= n/2; i++)
            {
                Console.WriteLine(new string('.', dots) + '/' + new string('*', stars) + '\\' + new string('.', dots));
                dots--;
                stars += 2;
            }
        }
    }
}
