using System;

namespace EmployeeAttendance
{
    class Program
    {
        // Declaring constants
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int isAbsent = 0;
        public const int EmpWagePerHr = 150;
        public const int TotalWorkingDays = 20;

        static void Main(string[] args)
        {
            // Declaring variables
            int EmpWage = 0;
            int day = 0;
            int EmpHrs = 0;
            int TotalEmpWage = 0;

            for (day = 0; day<20; day++)
            {
                // Creating random number
                Random random = new Random();
                int EmpCheck = random.Next(0,3);

                switch (EmpCheck)
                {
                    case 1:
                        EmpHrs = 8;

                    case 2:
                        EmpHrs = 5;
                    
                    default:
                        EmpHrs = 0;
                }
                EmpWage = EmpWagePerHr * EmpHrs;
                TotalEmpWage += EmpWage;
                
            }
            Console.WriteLine("The total employee wage = " + TotalEmpWage);
        }
    }
}
