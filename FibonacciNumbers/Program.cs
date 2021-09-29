using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Numbers uptil nth number!");
            Console.WriteLine("Enter the nth number to output:");
            int nth = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            if (nth == 0)
            {
                Console.WriteLine("Enter a non zero number!!");
            }
            else if (nth == 1)
            {
                Console.WriteLine(a);
            }
            else if (nth == 2)
            {
                Console.WriteLine(a + " " + b);
            }
            else
            {
                Console.Write(a + " " + b);
                for (int i = 3; i <= nth; i++)
                {
                    int c = a + b;
                    Console.Write(" " + c);
                    a = b;
                    b = c;
                }
            }
        }
    }
}
