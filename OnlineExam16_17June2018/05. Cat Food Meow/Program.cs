using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Cat_Food_Meow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int col = 1; col <= n - 1; col++)
            {
                Console.Write(".");
            }
            Console.Write("|");

            for (int col = 1; col <= n; col++)
            {
                Console.Write("\\/");
            }

            Console.Write("|");
            for (int col = 1; col <= n - 1; col++)
            {
                Console.Write(".");
            }
            Console.WriteLine();

            for (int col = 1; col <= n - 1; col++)
            {
                Console.Write(".");
            }
            Console.Write("|");

            for (int col = 1; col <= n; col++)
            {
                Console.Write("~~");
            }

            Console.Write("|");
            for (int col = 1; col <= n - 1; col++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
            string bracket = "{}";
            int number = n;
            int num1 = 0;
            string middle = string.Join(bracket, new string[number + 1]);
            for (int i = 1; i <= n; i++)
            {
                middle = string.Join(bracket, new string[number + 1]);
                Console.WriteLine(new string('.', n -1) + '|' + new string(' ', num1) + middle + new string(' ', num1) + '|' + new string('.', n - 1));
                number-= 1;
                num1+= 1;
            }
            for (int col = 1; col <= n - 1; col++)
            {
                Console.Write(".");
            }
            Console.Write("|");

            Console.Write(new string(' ', n - 2) + "MEOW" + new string(' ', n - 2));

            Console.Write("|");
            for (int col = 1; col <= n - 1; col++)
            {
                Console.Write(".");
            }

            Console.WriteLine();

            for (int col = 1; col <= n - 1; col++)
            {
                Console.Write(".");
            }
            Console.Write("|");

            Console.Write(new string(' ', n - 2) + "FOOD" + new string(' ', n - 2));

            Console.Write("|");
            for (int col = 1; col <= n - 1; col++)
            {
                Console.Write(".");
            }

            Console.WriteLine();


            number = 1;            
            middle = string.Join(bracket, new string[number + 1]);
            num1 = n - 1;

            for (int i = 1; i <= n; i++)
            {
                middle = string.Join(bracket, new string[number + 1]);
                Console.WriteLine(new string('.', n - 1) + '|' + new string(' ', num1) + middle + new string(' ', num1) + '|' + new string('.', n - 1));
                num1 -= 1;
                number += 1;
            }


            for (int col = 1; col <= n - 1; col++)
            {
                Console.Write(".");
            }
            Console.Write("|");

            for (int col = 1; col <= n; col++)
            {
                Console.Write("~~");
            }

            Console.Write("|");
            for (int col = 1; col <= n - 1; col++)
            {
                Console.Write(".");
            }
            Console.WriteLine();

            for (int col = 1; col <= n - 1; col++)
            {
                Console.Write(".");
            }
            Console.Write("|");

            for (int col = 1; col <= n; col++)
            {
                Console.Write("\\/");
            }

            Console.Write("|");
            for (int col = 1; col <= n - 1; col++)
            {
                Console.Write(".");
            }
            Console.WriteLine();

        }
    }
}
