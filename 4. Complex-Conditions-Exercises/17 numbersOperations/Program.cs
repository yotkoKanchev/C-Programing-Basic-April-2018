using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17numbersOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            double result = 0;
            string evenOrOdd = "";
            
            switch (symbol)
            {
                case '+':
                    result = n1 + n2;
                    if (result % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine($"{n1} + {n2} = {result} - {evenOrOdd}");
                    break;
                case '-':
                    result = n1 - n2;
                    if (result % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine($"{n1} - {n2} = {result} - {evenOrOdd}");
                    break;
                case '*':
                    result = n1 * n2;
                    if (result % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine($"{n1} * {n2} = {result} - {evenOrOdd}");
                    break;
                case '/':
                    result = n1 / n2;
                    if (n2 != 0)
                    {
                        Console.WriteLine($"{n1} / {n2} = {result:f2}");
                    }
                    else                    
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    break;
                case '%':
                    result = n1 % n2;
                    if (n2 != 0)
                    {
                        Console.WriteLine($"{n1} % {n2} = 1");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    break;
            }
        }
    }
}
