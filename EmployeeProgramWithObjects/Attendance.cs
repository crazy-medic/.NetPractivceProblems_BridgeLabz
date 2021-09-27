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
            if (att == 0)
            {
                Console.WriteLine("Employee is absent");
            }
            else
            {
                Console.WriteLine("Employee is present");
                FullDayWage Wage = new FullDayWage();
                Wage.EmpWage();
            }
                

        }
    }
}
