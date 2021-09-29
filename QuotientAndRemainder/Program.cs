using System;

namespace QuotientAndRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quotient and Remainder program.");
            Console.WriteLine("Enter the bigger number to be divided:");
            int Big = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the smaller number to be used for divide:");
            int Small = int.Parse(Console.ReadLine());
            int Quotient = Big / Small;
            int Remainder = Big - (Quotient * Small);
            Console.WriteLine("Qoutient of the 2 numbers are: " + Quotient);
            Console.WriteLine("Remainder : " + Remainder);
        }
    }
}
