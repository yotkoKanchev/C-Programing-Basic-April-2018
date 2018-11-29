using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09cup
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dots = n;
            int dieses = 3 * n;

            for (int i = 1; i <= n/2; i++)
            {
                Console.WriteLine(new string('.', dots) + new string('#',dieses) + new string('.',dots));
                dots++;
                dieses -= 2;
            }

            int middleDots = dieses - 2;
            for (int i = 1; i <= n/2+1; i++)
            {
                Console.WriteLine(new string('.', dots) + '#' + new string('.',middleDots) + '#' + new string('.',dots));
                dots++;
                middleDots -= 2;
            }
            dots -= 1;
            middleDots += 2;
            Console.WriteLine(new string('.', dots) + new string('#',middleDots+2) + new string('.',dots));

            dots -= 2;
            dieses = middleDots + 6;

            for (int i = 1; i <= n+2; i++)
            {
                if (i == n / 2 + 1)
                {
                    Console.WriteLine(new string('.', (n*5-10)/2) + "D^A^N^C^E^" + new string('.', (n*5-10)/2));

                }
                else
                {
                    Console.WriteLine(new string('.', dots) + new string('#', dieses) + new string('.', dots));
                }
            }

        }
    }
}
