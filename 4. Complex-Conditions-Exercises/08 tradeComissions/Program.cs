using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08tradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double comission = 0;
            if ((town == "Sofia" || town == "Varna" || town == "Plovdiv") && sales > 0)
            {
                switch (town)
                {
                    case "Sofia":
                        if (sales <= 500)
                        {
                            comission = sales * 0.05;
                        }
                        else if (sales <= 1000)
                        {
                            comission = sales * 0.07;
                        }
                        else if (sales <= 10000)
                        {
                            comission = sales * 0.08;
                        }
                        else if (sales > 10000)
                        {
                            comission = sales * 0.12;
                        }
                        break;
                    case "Varna":
                        if (sales <= 500)
                        {
                            comission = sales * 0.045;
                        }
                        else if (sales <= 1000)
                        {
                            comission = sales * 0.075;
                        }
                        else if (sales <= 10000)
                        {
                            comission = sales * 0.10;
                        }
                        else if (sales > 10000)
                        {
                            comission = sales * 0.13;
                        }
                        break;

                    case "Plovdiv":
                        if (sales <= 500)
                        {
                            comission = sales * 0.055;
                        }
                        else if (sales <= 1000)
                        {
                            comission = sales * 0.08;
                        }
                        else if (sales <= 10000)
                        {
                            comission = sales * 0.12;
                        }
                        else if (sales > 10000)
                        {
                            comission = sales * 0.145;
                        }
                        break;
                }
                Console.WriteLine($"{comission:f2}");
            }
            else
            {
                    Console.WriteLine("error");
            }            
        }
    }
}
