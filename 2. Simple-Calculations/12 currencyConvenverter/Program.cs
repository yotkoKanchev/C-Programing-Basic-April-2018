using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currencyConvenverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            string inCurrency = Console.ReadLine();
            string outCurrency = Console.ReadLine();

            double lvInUsd = 1.79549;
            double lvInEuro = 1.95583;
            double lvInGbp = 2.53405;

            double result = 0;

            if (inCurrency == "USD" && outCurrency == "BGN")
            {
                result = amount * lvInUsd;
            }
            else if (inCurrency == "USD" && outCurrency == "EUR")
            {
                result = amount * lvInUsd / lvInEuro;
            }
            else if (inCurrency == "USD" && outCurrency == "GBP" )
            {
                result = amount * lvInUsd / lvInGbp;
            }
            else if (inCurrency == "EUR" && outCurrency == "BGN")
            {
                result = amount * lvInEuro;
            }
            else if (inCurrency == "EUR" && outCurrency == "USD")
            {
                result = amount * lvInEuro / lvInUsd;
            }
            else if (inCurrency == "EUR" && outCurrency == "GBP")
            {
                result = amount * lvInEuro / lvInGbp;
            }
            else if (inCurrency == "GBP" && outCurrency == "BGN")
            {
                result = amount * lvInGbp;
            }
            else if (inCurrency == "GBP" && outCurrency == "USD")
            {
                result = amount * lvInGbp / lvInUsd;
            }
            else if (inCurrency == "GBP" && outCurrency == "EUR")
            {
                result = amount * lvInGbp / lvInEuro;
            }
            else if (inCurrency == "BGN" && outCurrency == "USD")
            {
                result = amount / lvInUsd;
            }
            else if (inCurrency == "BGN" && outCurrency == "EUR")
            {
                result = amount / lvInEuro;
            }
            else if (inCurrency == "BGN" && outCurrency == "GBP")
            {
                result = amount / lvInGbp;
            }

            Console.WriteLine($"{result:f2} {outCurrency}");
        }
    }
}
