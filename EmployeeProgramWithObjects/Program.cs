using System;

namespace EmployeeProgramWithObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Wage Computation Program");
            Attendance att = new Attendance();
            Random rand = new Random();
            att.PresentAbsent(rand.Next(0,2));
        }
    }
}
