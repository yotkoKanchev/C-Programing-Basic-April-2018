using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftRightDashes = (n - 1) / 2;
            int midDashes = n - 2 * leftRightDashes - 2;

            if (n == 1)
            {
                Console.WriteLine("*");
            }

            else
            {
                if (midDashes < 0)
                {
                    midDashes = 1;
                    Console.WriteLine((new string('-', leftRightDashes)) + '*' + new string('-', leftRightDashes));
                    Console.WriteLine((new string('-', leftRightDashes - 1)) + '*' + new string('-', midDashes) + '*' + new string('-', leftRightDashes - 1));
                    for (int i = 0; i < n / 2 - 1; i++)
                    {
                        leftRightDashes--;
                        midDashes += 2;
                        Console.WriteLine((new string('-', leftRightDashes - 1)) + '*' + new string('-', midDashes) + '*' + new string('-', leftRightDashes - 1));
                    }
                    for (int i = 0; i < n / 2 - 1; i++)
                    {
                        leftRightDashes++;
                        midDashes -= 2;
                        Console.WriteLine((new string('-', leftRightDashes - 1)) + '*' + new string('-', midDashes) + '*' + new string('-', leftRightDashes - 1));
                    }
                    Console.WriteLine((new string('-', leftRightDashes)) + '*' + new string('-', leftRightDashes));

                }

                else
                {
                    Console.WriteLine((new string('-', leftRightDashes)) + '*' + new string('-', midDashes) + '*' + new string('-', leftRightDashes));
                    for (int i = 0; i < n / 2 - 1; i++)
                    {
                        leftRightDashes--;
                        midDashes += 2;
                        Console.WriteLine((new string('-', leftRightDashes)) + '*' + new string('-', midDashes) + '*' + new string('-', leftRightDashes));
                    }
                    for (int i = 0; i < n / 2 - 1; i++)
                    {
                        leftRightDashes++;
                        midDashes -= 2;
                        Console.WriteLine((new string('-', leftRightDashes)) + '*' + new string('-', midDashes) + '*' + new string('-', leftRightDashes));
                    }
                }
            }
        }
    }
}
