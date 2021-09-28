using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeProgramWithObjects
{
    class PartTimeWage : FullDayWage
    {
        public int PartWage = 120;
        public void EmpPartTimeWage()
        {
            Console.WriteLine("Employee wage today is " + PartWage);
        }

    }
}
