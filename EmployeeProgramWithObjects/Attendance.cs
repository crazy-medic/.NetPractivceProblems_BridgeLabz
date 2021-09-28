using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeProgramWithObjects
{
    class Attendance
    {
        public void PresentAbsent(int a)
        {
            int att = a;
            switch (att)
            {
                case 0:
                    {
                        Console.WriteLine("Employee is absent");
                        Console.WriteLine("There is no pay today");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Employee is present for full time today");
                        MonthlyWage wage = new MonthlyWage();
                        wage.ThisMonthWageFullTime();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Employee is present for part time today");
                        MonthlyWage wage1 = new MonthlyWage();
                        wage1.ThisMonthWagePartTime();
                        break;
                    }
                default:
                    {
                        break;
                    }

            }
                
                

        }
    }
}
