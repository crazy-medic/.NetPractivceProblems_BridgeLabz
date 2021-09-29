using System;

namespace SawpNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number swapping program");
            Console.WriteLine("Enter 1st number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number:");
            int b = int.Parse(Console.ReadLine());
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping:");
            Console.WriteLine("1st number is " + a);
            Console.WriteLine("2nd number is " + b);
        }
    }
}
