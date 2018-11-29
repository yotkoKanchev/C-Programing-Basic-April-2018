using System;

namespace _04._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeLenght = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int cakePieces = cakeLenght * cakeWidth;

            while (input != "STOP")
            {
                int pieces = int.Parse(input);

                cakePieces -= pieces;
                if (cakePieces < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
                    return;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{cakePieces} pieces are left.");
        }
    }
}