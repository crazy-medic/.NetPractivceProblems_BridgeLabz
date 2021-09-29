using System;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perfect Number Program!");
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            int i = 1;
            int total = 0;

            for (i = 1; i < num; i++)
            {
                if (num % i == 0)
                    total += i;
            }
            if (total == num)
                Console.WriteLine(num + " is a perfect number");
            else
                Console.WriteLine(num + " is not a perfect number");
        }
    }
}
