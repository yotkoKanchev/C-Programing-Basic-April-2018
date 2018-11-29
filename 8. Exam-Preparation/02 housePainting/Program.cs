using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02housePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double houseHight = double.Parse(Console.ReadLine());
            double wallLenght = double.Parse(Console.ReadLine());
            double roofHight = double.Parse(Console.ReadLine());

            double wallsArea = 2 * (houseHight * houseHight + houseHight * wallLenght) - 2 * 1.2 - 2 * 1.5 * 1.5;
            double roofArea = 2 * (wallLenght * houseHight + houseHight * roofHight / 2);

            double greenPaint = wallsArea / 3.4;
            double redPaint = roofArea / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
