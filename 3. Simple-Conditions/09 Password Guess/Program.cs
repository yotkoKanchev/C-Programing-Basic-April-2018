using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pasword = "s3cr3t!P@ssw0rd";

                if (input == pasword)
                Console.WriteLine("Welcome");

                else
                Console.WriteLine("Wrong password!");
        }
    }
}
