using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _19JulyAssesment
{
    class Problem
    {
        public static void Assesment()
        {
            string[] str = {"aabb","abb", "abbb","aaab"};

            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} matching a string", s,
                            isValid(s) ? "is" : "is not");
            }

            Console.ReadKey();
            // RE.EmailID();
        }
        // method containing the regex
        public static bool isValid(string inputString)
        {
            // The ^ and $ characters are achors that specify that the string should start and end patteen,respectively
            string strRegex = @"^a{1}b{2,3}$";

                Regex re = new Regex(strRegex);

            // The IsMatch method is used to validate a string or to ensure that a string conforms to a particular pattern.
            if (re.IsMatch(inputString))
                return (true);
            else
                return (false);
        }
    }
}