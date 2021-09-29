using System;

namespace PhonebookApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Person P1 = new Person();
            P1.PrintHeading();
            P1.PrintDetails();
        }
    }
}
