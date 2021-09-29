using System;

namespace _2ToPowerN
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 1;
            Console.WriteLine("Power of 2 program!");
            Console.WriteLine("Enter the power value for 2(less than 31):");
            int Power = int.Parse(Console.ReadLine());
            if (Power == 0)
            {
                Console.WriteLine("Power of 2 to 0 is 1");
            }
            else
            {
                while (b < Power)
                {
                    a = a * 2;
                    b++;
                }
                Console.WriteLine(value: "Power of 2 to " + Power + " = " + a);
            }
        }
    }
}
