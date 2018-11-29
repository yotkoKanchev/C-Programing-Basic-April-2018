using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numSymb = n - 2;
            string symb = " -";
            string newSym = string.Join(symb, new string[numSymb + 1]);

            Console.WriteLine('+' + newSym + ' ' + '+');

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine('|' + newSym + ' ' + '|');
            }

            Console.WriteLine('+' + newSym + ' ' + '+');
        }
    }
}
