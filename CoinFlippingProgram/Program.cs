using System;

namespace CoinFlippingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalFlips = 0;
            int HeadCount = 0;
            int TailCount = 0;
            int HeadPercent = 0;
            int TailPercent = 0;
            Console.WriteLine("Welcome to coin flip!");
            Console.WriteLine("Enter the number of times to flip:");
            int NumberOfFlips = int.Parse(Console.ReadLine());
            while (TotalFlips < NumberOfFlips)
            {
                Random random = new Random();
                int Flip = random.Next(0, 2);
                if (Flip == 0)
                {
                    HeadCount += 1;
                    Console.WriteLine("Heads flipped");
                    TotalFlips++;
                }
                else
                {
                    TailCount += 1;
                    Console.WriteLine("Tails flipped");
                    TotalFlips++;
                }
            }
            HeadPercent = ((HeadCount * 100) / NumberOfFlips);
            TailPercent = ((TailCount * 100) / NumberOfFlips);
            Console.WriteLine("Heads flipped = " + HeadCount);
            Console.WriteLine("Tails flipped = " + TailCount);
            Console.WriteLine("Percent of Heads = " + HeadPercent);
            Console.WriteLine("Percent of Tails = " + TailPercent);
        }
    }
}
