using System;

namespace ConstantOrVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vowel Checker Program!");
            Console.WriteLine("Enter a letter");
            char Input = Convert.ToChar(Console.ReadLine());
            if (Input == 'a' || Input == 'e' || Input == 'i' || Input == 'o' || Input == 'u' || Input == 'A' || Input == 'E' || Input == 'O' || Input == 'U' || Input == 'I')
            {
                Console.WriteLine("Entered charecter is vowel!");
            }
            else
            {
                Console.WriteLine("Entered charecter is constant!");
            }
        }
    }
}
