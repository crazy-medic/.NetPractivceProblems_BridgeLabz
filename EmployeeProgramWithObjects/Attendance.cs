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
                            break;
                    }
                case 1:
                    {
                        Console.WriteLine("Employee is present for full time today");
                        FullDayWage Wage = new FullDayWage();
                        Wage.EmpFullTimeWage();
                            break;
                    }
                case 2:
                    {
                        Console.WriteLine("Employee is present for part time today");
                        PartTimeWage Wage1 = new PartTimeWage();
                        Wage1.EmpPartTimeWage();
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
