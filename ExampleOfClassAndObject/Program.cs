using System;

namespace ExampleOfClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Car obj = new Car();
            Car obj1 = new Car("Alto");
            Console.WriteLine(obj.color);
            Console.WriteLine(obj1.NameOfCar);
            obj.cardetails();
        }
    }

    class Car
    {
        public string color = "red";
        public string NameOfCar = "";
        public Car(string name)
        {
            NameOfCar = name;
        }

        public Car()
        { }
        public void cardetails()
        {
            Console.WriteLine("Swift");
        }
        
    }
}
