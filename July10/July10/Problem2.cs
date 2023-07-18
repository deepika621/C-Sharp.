using System;
using System.Collections.Generic;
using System.Text;

namespace July10
{
    public class Problem2
    {
        public static void FindEligibility()
        {
            Console.WriteLine("Enter Marks Obtained in Maths:");
            int mathsMarks=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks Obtained in Physics:");
            int physicsMarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks Obtained in Chemistry:");
            int chemistryMarks = Convert.ToInt32(Console.ReadLine());
            int totalMarks=physicsMarks+chemistryMarks+mathsMarks;
            if (mathsMarks >= 65 && physicsMarks >= 55 && chemistryMarks >= 50 && totalMarks>=180)
            {
                Console.WriteLine("The Candidate is Eligible for Admission");
            }
            else if (mathsMarks >=65 && totalMarks >= 140)
            {
                Console.WriteLine("The Candidate is Eligible for Admission");
            }
            else
            {
                Console.WriteLine("The Candidate is not Eligible for Admission");
            }
        }

    }
}
