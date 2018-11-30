using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Cat_Food1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cats = int.Parse(Console.ReadLine());

            int smallCats = 0;
            int bigCats = 0;
            int hugeCats = 0;

            double totalFoodInGrams = 0;

            for (int i = 0; i < cats; i++)
            {
                var foodInGrams = double.Parse(Console.ReadLine());

                totalFoodInGrams = totalFoodInGrams + foodInGrams;
            

                if (foodInGrams >= 100 && foodInGrams < 200)
                {
                    smallCats++;
                }

                else if (foodInGrams >= 200 && foodInGrams < 300)
                {
                    bigCats++;
                }

                else if (foodInGrams >= 300 && foodInGrams <= 400)
                {
                    hugeCats++;
                }
                
            }
            var totalFoodInKg = totalFoodInGrams / 1000;
            var price = totalFoodInKg * 12.45;

            Console.WriteLine($"Group 1: {smallCats} cats.");
            Console.WriteLine($"Group 2: {bigCats} cats.");
            Console.WriteLine($"Group 3: {hugeCats} cats.");
            Console.WriteLine($"Price for food per day: {price:F2} lv. ");
        }
    }
}
