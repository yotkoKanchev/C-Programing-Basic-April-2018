using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metricConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputNumber = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();

            double meters = 0;
            double result = 0;

            if (inputUnit == "m")
            {
                meters = inputNumber;
            }

            else if (inputUnit == "km")
            {
                meters = inputNumber / 0.001;
            }

            else if (inputUnit == "mm")
            {
                meters = inputNumber / 1000;
            }

            else if (inputUnit == "cm")
            {
                meters = inputNumber / 100;
            }

            else if (inputUnit == "mi")
            {
                meters = inputNumber / 0.000621371192;
            }

            else if (inputUnit == "in")
            {
                meters = inputNumber / 39.3700787;
            }

            else if (inputUnit == "ft")
            {
                meters = inputNumber / 3.2808399;
            }

            else if (inputUnit == "yd")
            {
                meters = inputNumber / 1.0936133;
            }

            if (outputUnit == "m")
            {
                result = meters;
            }

            else if (outputUnit == "ft")
            {
                result = meters * 3.2808399;
            }

            else if (outputUnit == "cm")
            {
                result = meters * 100;
            }

            else if (outputUnit == "mi")
            {
                result = meters * 0.000621371192;
            }

            else if (outputUnit == "in")
            {
                result = meters * 39.3700787;
            }

            else if (outputUnit == "km")
            {
                result = meters * 0.001;
            }

            else if (outputUnit == "mm")
            {
                result = meters * 1000;
            }

            else if (outputUnit == "yd")
            {
                result = meters * 1.0936133;
            }

            Console.WriteLine($"{result:f8}");
        }
    }
}
