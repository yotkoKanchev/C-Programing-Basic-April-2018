using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double input_amount = double.Parse(Console.ReadLine());
            double amountInCoins = input_amount * 100;
            int amount = (int)amountInCoins;
            int coins = 0;
            int coinsNumber = 0;
            while (amount>0)
            {
                if (amount >= 200)
                {
                    coinsNumber = amount / 200;
                    coins += coinsNumber;
                    amount = amount - 200 * coinsNumber;
                }
                else if (amount >= 100)
                {
                    coinsNumber = amount / 100;
                    coins += coinsNumber;
                    amount = amount - coinsNumber * 100;
                }
                else if (amount >= 50)
                {
                    coinsNumber = amount / 50;
                    coins += coinsNumber;
                    amount = amount - coinsNumber * 50;
                }
                else if (amount >= 20)
                {
                    coinsNumber = amount / 20;
                    coins += coinsNumber;
                    amount = amount - coinsNumber * 20;
                }
                else if (amount >= 10)
                {
                    coinsNumber = amount / 10;
                    coins += coinsNumber;
                    amount = amount - coinsNumber * 10;
                }
                else if (amount >= 5)
                {
                    coinsNumber = amount / 5;
                    coins += coinsNumber;
                    amount = amount - coinsNumber * 5;
                }
                else if (amount >= 2)
                {
                    coinsNumber = amount / 2;
                    coins += coinsNumber;
                    amount = amount - coinsNumber * 2;
                }
                else if (amount >= 1)
                {
                    coinsNumber = amount / 1;
                    coins += coinsNumber;
                    amount = amount - coinsNumber * 1;
                }                
            }           
            Console.WriteLine(coins);
        }
    }
}
