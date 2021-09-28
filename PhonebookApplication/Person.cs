using System;
using System.Collections.Generic;
using System.Text;

namespace PhonebookApplication
{
    class Person : ContactDetails
    {
        public void PrintHeading()
        {
            Console.WriteLine("Enter the details of the person:");
            Console.WriteLine("Enter the name of the person:");
            NameOfPerson = Console.ReadLine();
            Console.WriteLine("Enter the name of the city:");
            City = Console.ReadLine();
            Console.WriteLine("Enter the email:");
            email = Console.ReadLine();
            Console.WriteLine("Enter the phone number");
            PhNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Zip Code");
            ZipCode = long.Parse(Console.ReadLine());
        }

        public void PrintDetails()
        {
            Console.WriteLine("The details of the person entered:");
            Console.WriteLine("Name : " + NameOfPerson);
            Console.WriteLine("City : " + City);
            Console.WriteLine("Email : " + email);
            Console.WriteLine("Phone number : " + PhNumber);
            Console.WriteLine("Zip : " + ZipCode);
        }
    }
}
