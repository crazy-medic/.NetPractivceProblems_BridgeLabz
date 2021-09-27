using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeProgramWithObjects
{
    class Attendance
    {
        public void PresentAbsent(int a)
        {
            if (a == 0)
                Console.WriteLine("Employee is absent");
            else
                Console.WriteLine("Employee is present");
        }
    }
}
