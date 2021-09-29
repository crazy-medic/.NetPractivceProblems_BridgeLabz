using System;

namespace LeapNotLeap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year to check:");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 && year%100 != 0 || year%400 == 0)
            {
                Console.WriteLine("The given year is leap year!");
            }
            else
            {
                Console.WriteLine("The entered year is not leap!");
            }
        }
    }
}
