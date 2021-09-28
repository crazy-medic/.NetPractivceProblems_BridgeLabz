using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeProgramWithObjects
{
    class MonthlyWage : FullDayWage
    {
        public int TotalWageThisMonth;
        public void ThisMonthWageFullTime()
        {
            FullDayWage Wage = new FullDayWage();
            Wage.EmpFullTimeWage();
            TotalWageThisMonth += Wage.FullWage;
            Console.WriteLine("This months total wage till today is " + TotalWageThisMonth);
        }
        public void ThisMonthWagePartTime()
        {
            PartTimeWage Wage1 = new PartTimeWage();
            Wage1.EmpPartTimeWage();
            TotalWageThisMonth += Wage1.PartWage;
            Console.WriteLine("This months total wage till today is " + TotalWageThisMonth);
        }
    }
}
