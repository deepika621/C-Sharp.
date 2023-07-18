using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    public class EmployeeAttendence
    {
        public void FindEmpPorA()
        {
            Random random = new Random();
            int attendence = random.Next(0, 3);
            int empRatePerHr = 20;
            int salary;
            if (attendence == 0)
            {
                Console.WriteLine("Employee is Absent");
                int empHrs = 0;
                salary = (empRatePerHr * empHrs);
                Console.WriteLine(salary);

            }
            else if(attendence == 1)
            {
                Console.WriteLine("Employee is full-time Present");
                int empHrs = 8;
                salary = (empRatePerHr * empHrs);
                Console.WriteLine(salary);
            }else
            {
                Console.WriteLine("Employee is Part-time Present");
                int empHrs = 4;
                salary = (empRatePerHr * empHrs);
                Console.WriteLine(salary);
            }
        }
    }
}

