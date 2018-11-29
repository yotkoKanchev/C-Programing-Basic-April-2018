using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01personalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            string result = "";
            switch (gender)
            {
                case "m":
                    if (age < 16)
                    {
                        result = "Master";
                    }
                    else
                    {
                        result = "Mr.";
                    }
                    break;
                case "f":
                    if (age < 16)
                    {
                        result = "Miss";
                    }
                    else
                    {
                        result = "Ms.";
                    }
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
