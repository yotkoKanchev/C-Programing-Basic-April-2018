using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04fruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string result = "";
            if (fruit == "banana" || fruit == "apple" || fruit == "kiwi" || fruit == "cherry" || fruit == "lemon" || fruit == "grapes")
            {
                result = "fruit";
            }
            else if (fruit == "tomato" || fruit == "cucumber" || fruit == "pepper" || fruit == "carrot")
            {
                result = "vegetable";
            }
            else
            {
                result = "unknown";
            }
            Console.WriteLine(result);
        }
    }
}
