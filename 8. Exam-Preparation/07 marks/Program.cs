using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07marks
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfstudents = int.Parse(Console.ReadLine());

            int top = 0;
            int veryGood = 0;
            int good = 0;
            int fail = 0;

            double totalMarks = 0;
            for (int i = 1; i <= numberOfstudents; i++)
            {
                double mark = double.Parse(Console.ReadLine());
                totalMarks += mark;
                if (mark >= 5.00)
                {
                    top++;
                }
                else if (mark >= 4)
                {
                    veryGood++;
                }
                else if (mark >= 3)
                {
                    good++;
                }
                else if (mark < 3)
                {
                    fail++;
                }
            }
            double averageMark = totalMarks / (double)numberOfstudents;
            double topProcentige = 100 / (double)numberOfstudents * top;
            double fourTofive = 100 / (double)numberOfstudents * veryGood;
            double threeTofour = 100 / (double)numberOfstudents * good;
            double failProcentige = 100 / (double)numberOfstudents * fail;

            Console.WriteLine($"Top students: {topProcentige:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {fourTofive:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {threeTofour:f2}%");
            Console.WriteLine($"Fail: {failProcentige:f2}%");
            Console.WriteLine($"Average: {averageMark:f2}");
        }
    }
}
