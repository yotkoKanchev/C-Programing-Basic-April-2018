using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pairs1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int firstPairSum = firstNum + secondNum;
            int maxDiff = 0;

            for (int i = 0; i < n - 1; i++)
            {
                int nextFirsN = int.Parse(Console.ReadLine());
                int nextSecondN = int.Parse(Console.ReadLine());

                int nextPairSum = nextFirsN + nextSecondN;

                int pairsDiff = Math.Abs(nextPairSum - firstPairSum);

                if (pairsDiff > maxDiff)
                {
                    maxDiff = pairsDiff;
                }

                firstPairSum = nextPairSum;
            }

            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value={firstPairSum}");
            }

            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}