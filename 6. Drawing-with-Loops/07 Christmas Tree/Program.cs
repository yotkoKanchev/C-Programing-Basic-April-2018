using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSpaces = n + 1;

            string emptySpaces = new string(' ', leftSpaces);
            Console.WriteLine(emptySpaces + "|" + emptySpaces);

            leftSpaces = leftSpaces - 2;

            for (int i = 0; i < n; i++)
            {
                emptySpaces = new string(' ', leftSpaces);
                Console.Write(emptySpaces);
                Console.Write(new string('*', i + 1));
                Console.Write(" | ");
                Console.Write(new string('*', i + 1));
                Console.WriteLine();
                leftSpaces--;
            }
        }
    }
}
