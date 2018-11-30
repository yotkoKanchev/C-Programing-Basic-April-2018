using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Cat_Diet
{
    class Program
    {
        static void Main(string[] args)
        {
            double fats = double.Parse(Console.ReadLine());
            double proteins = double.Parse(Console.ReadLine());
            double carbohs = double.Parse(Console.ReadLine());
            double calories = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine());

            double gramsFromFats = ((fats / 100) * calories) / 9;
            double gramsFromProteins = ((proteins / 100) * calories) / 4;
            double gramsFromCarbohs = ((carbohs / 100) * calories) / 4;
            double totalWeight = gramsFromFats + gramsFromCarbohs + gramsFromProteins;
            double caloriesPergram = calories / totalWeight ;

            double finalCalories = caloriesPergram * (1 - (water / 100));

            Console.WriteLine($"{finalCalories:F4}");


        }
    }
}
