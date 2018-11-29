using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12lettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char l1 = char.Parse(Console.ReadLine());
            char l2 = char.Parse(Console.ReadLine());
            char l3 = char.Parse(Console.ReadLine());

            int combinationsNumber = 0;

            for (int i = l1; i <= l2; i++)
            {
                for (int j = l1; j <= l2; j++)
                {
                    for (int k = l1; k <= l2; k++)
                    {
                        if (i != l3 && j != l3 && k != l3)
                        {
                            combinationsNumber++;
                            Console.Write($"{(char)i}{(char)j}{(char)k} ");                                                        
                        }
                    }
                }                
            }
            Console.WriteLine(combinationsNumber);
        }
    }
}
