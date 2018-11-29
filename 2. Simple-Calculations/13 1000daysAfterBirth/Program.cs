using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131000daysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            date = date.AddDays(999);
            string pattern = "dd-MM-yyyy";
            Console.WriteLine(date.ToString(pattern));
            
        }
    }
}
