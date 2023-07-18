using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    public class Switch
    {
        public static void UsingSwitch()
        {
            Random random = new Random();
            int attendence = random.Next(0, 3);
            int empRatePerHr = 20;
            int numofWorkingDay = 20;
            int salary;
            int empHrs;
            int totalSalary;
            string message;
            switch (attendence)
            {
            case 0:
                message = "Employee is Absent";
                empHrs = 0;
                salary = (empRatePerHr * empHrs);
                Console.WriteLine(salary);
                totalSalary = (numofWorkingDay * salary);
                Console.WriteLine(totalSalary);
                break;
            case 1:
                message = "Employee is Full-time Present";
                empHrs = 8;
                salary = (empRatePerHr * empHrs);
                Console.WriteLine(salary);
                totalSalary = (numofWorkingDay * salary);
                Console.WriteLine(totalSalary);
                break;
            case 2:
                message = "Employee is Part-time Present";
                empHrs = 4;
                salary = (empRatePerHr * empHrs);
                Console.WriteLine(salary);
                totalSalary = (numofWorkingDay * salary);
                Console.WriteLine(totalSalary);
                break;
            default:
            message = "Invalid attendence value";
            break;

                }
            Console.WriteLine(message);
            //int totalSalary = (numofWorkingDay * salary);
            //Console.WriteLine(totalSalary);
        } 
    }
}
