using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cat_Shirt
{
    class Program
    {
        static void Main(string[] args)
        {
            double sleeveSize = double.Parse(Console.ReadLine());
            double fronPartSize = double.Parse(Console.ReadLine());
            string fabric = Console.ReadLine();
            string tieOrNo = Console.ReadLine();

            double totalSize = 2 * (sleeveSize + fronPartSize);

            
            totalSize = totalSize + 0.1 * totalSize;
            
            double price = 0;

            switch (fabric)
            {

                case "Linen":
                    price = totalSize / 100 * 15 + 10;
                    break;

                case "Cotton":
                    price = totalSize / 100 * 12 + 10;
                    break;

                case "Denim":
                    price = totalSize / 100 * 20 + 10;
                    break;

                case "Twill":
                    price = totalSize / 100 * 16 + 10;
                    break;

                case "Flannel":
                    price = totalSize / 100 * 11 + 10;
                    break;

                default:
                    
                    break;
            }

            if (tieOrNo == "Yes")
            {
                price *= 1.2;
            }

            Console.WriteLine($"The price of the shirt is: {price:F2}lv.");
        }
    }
}
