using System;

namespace HarmonicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Harmonic number program");
            Console.WriteLine("Enter the nth number to print harmonic numbers:");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i < n)
            {
                Console.Write("1/" + i+" + ");
                i++;
            }
            Console.Write(value:"1/"+ i);
        }
    }
}
