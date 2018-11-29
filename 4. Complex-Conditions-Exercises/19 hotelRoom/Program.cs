using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19hotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double days = double.Parse(Console.ReadLine());
            double appartmentMoney = 0;
            double studioMoney = 0;
            switch (month)
            {
                case "May":
                    if (days < 15)
                    {
                        appartmentMoney = days * 65;
                    }
                    else
                    {
                        appartmentMoney = days * 65 * 0.9;
                    }

                    if (days > 7 && days < 15)
                    {
                        studioMoney = days * 50 * 0.95;
                    }
                    else if (days > 14)
                    {
                        studioMoney = days * 50 * 0.7;
                    }
                    else
                    {
                        studioMoney = days * 50;
                    }
                    break;
                case "June":
                    if (days < 15)
                    {
                        appartmentMoney = days * 68.70;
                    }
                    else
                    {
                        appartmentMoney = days * 68.70 * 0.9;
                    }

                    if (days > 14)
                    {
                        studioMoney = days * 75.20 * 0.8;
                    }
                    else
                    {
                        studioMoney = days * 75.20;
                    }
                    break;
                case "July":
                    studioMoney = days * 76;
                    if (days <15)
                    {
                        appartmentMoney = days * 77;
                    }
                    else
                    {
                        appartmentMoney = days * 77 * 0.9;
                    }
                    break;
                case "August":
                    studioMoney = days * 76;
                    if (days < 15)
                    {
                        appartmentMoney = days * 77;
                    }
                    else
                    {
                        appartmentMoney = days * 77 * 0.9;
                    }
                    break;
                case "September":
                    if (days < 15)
                    {
                        appartmentMoney = days * 68.70;
                    }
                    else
                    {
                        appartmentMoney = days * 68.70 * 0.9;
                    }

                    if (days > 14)
                    {
                        studioMoney = days * 75.20 * 0.8;
                    }
                    else
                    {
                        studioMoney = days * 75.20;
                    }
                    break;
                case "October":
                    if (days < 15)
                    {
                        appartmentMoney = days * 65;
                    }
                    else
                    {
                        appartmentMoney = days * 65 * 0.9;
                    }

                    if (days > 7 && days < 15)
                    {
                        studioMoney = days * 50 * 0.95;
                    }
                    else if (days > 14)
                    {
                        studioMoney = days * 50 * 0.7;
                    }
                    else
                    {
                        studioMoney = days * 50;
                    }
                    break;
            }
            Console.WriteLine($"Apartment: {appartmentMoney:f2} lv.");
            Console.WriteLine($"Studio: {studioMoney:f2} lv.");
        }
    }
}
