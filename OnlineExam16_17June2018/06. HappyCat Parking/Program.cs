using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.HappyCat_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            
            double money = 0;
            double totalMoneyOddDay = 0;
            double totalMoneyEvenDay = 0;
                double totalMoney = 0;


            for (int i = 1; i <= days; i++)
            {
                
                    if (i % 2 == 0)
                    {
                        money = (hours / 2) + (hours - (hours / 2)) * 2.5;
                    totalMoneyEvenDay += money;
                    }

                    if (i % 2 != 0)
                    {
                        money = (hours / 2) * 1.25  + (hours - (hours / 2));
                    totalMoneyOddDay += money;
                    }

                totalMoney = totalMoneyEvenDay + totalMoneyOddDay;
                
                Console.WriteLine($"Day: {i} - {money:F2} leva");                
                
            }
            Console.WriteLine($"Total: {totalMoney:F2} leva");

        }
    }
}
