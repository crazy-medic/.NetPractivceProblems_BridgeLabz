using System;

namespace ExampleOfEncapsulaion
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            obj.NameOfPerson = "TestingPerson";
            Console.WriteLine(obj);
        }
    }
}
