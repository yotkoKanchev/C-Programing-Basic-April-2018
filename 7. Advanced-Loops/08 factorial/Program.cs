using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            do
            {
                num = num * n;
                n--;
            } while (n > 0);
            Console.WriteLine(num);
        }
    }
}
