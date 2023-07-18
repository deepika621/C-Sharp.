using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace GeometryProblem
{
    public class Equal
    {
        public static void FindEqualorNot() {
            Console.WriteLine("Enter x-coordinate of first point of line 1:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y-coordinate of first point of line 1:");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter x-coordinate of second point of line 1:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y-coordinate of second point of line 1:");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter x-coordinate of first point of line 2:");
            double x3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y-coordinate of first point of line 2:");
            double y3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter x-coordinate of second point of line 2:");
            double x4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y-coordinate of second point of line 2:");
            double y4 = double.Parse(Console.ReadLine());
            //int x1, y1,x2,y2;
            double length1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double length2 = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
            Console.WriteLine("The length of the line1:" + length1);
            Console.WriteLine("The length of the line2:" + length2);
            //bool linesEqual = ((x1 == x3) && (y1 == y3) && (x2 == x4) && (y2 == y4)) || ((x1 == x4) && (y1 == y4) && (x2 == x3) && (y2 == y3));
            /*(if (length1==length2)
            {
                Console.WriteLine("The lines are equal");
            }
            else
            {
                Console.WriteLine("The lines are not equal");
            }*/
            int result = length1.CompareTo(length2);
            {
                if (result == 0)
                {
                    Console.WriteLine("The two lines are equal");
                }
                else if (result > 0)
                {
                    Console.WriteLine("Line 1 is greater than Line 2");
                }
                else
                {
                    Console.WriteLine("Line 1 is greater than Line 2");
                }
            }
        }
    }
}
