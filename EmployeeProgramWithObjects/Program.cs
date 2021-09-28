using System;

namespace EmployeeProgramWithObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int MonthlyWorkingDays = 20;
            int TotalWorkedDays = 0;
            Console.WriteLine("Employee Wage Computation Program");
            Attendance att = new Attendance();
            Random rand = new Random();
            while (TotalWorkedDays < MonthlyWorkingDays)
            {
                int Att = rand.Next(0, 3);
                att.PresentAbsent(Att);
                if (Att != 0)
                {
                    TotalWorkedDays++;
                }
            }
        }
    }
}
