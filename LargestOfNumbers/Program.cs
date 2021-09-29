using System;

namespace LargestOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Largest of numbers");
            Console.WriteLine("Enter 1st number:");
            int a = int.Parse(Console.ReadLine());
            int max = a;
            Console.WriteLine("Enter 2nd number:");
            int b = int.Parse(Console.ReadLine());
            if (b > max)
            {
                max = b;
            }
            Console.WriteLine("Enter 3rd number:");
            int c = int.Parse(Console.ReadLine());
            if (c > max)
            {
                max = c;
            }
            Console.WriteLine("Largest of these numbers is " + max);
        }
    }
}
