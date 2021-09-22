using System;

namespace EmployeeAttendance
{
    class Program
    {
        /// <summary>
        /// Employee Attendance Program.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Random random = new Random();
            int EmpCheck = random.Next(0,2);

            if (EmpCheck == 1)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
