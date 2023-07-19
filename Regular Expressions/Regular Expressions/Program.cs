using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] str = {"500009",
          "888686", "456734","098765","23456"};

            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid Pin Code.", s,
                            isValidPinCode(s) ? "is" : "is not");
            }

            Console.ReadKey();*/
            FirstnameLastname.FN_LN();
           // RE.EmailID();
        }
        // method containing the regex
        /*public static bool isValidPinCode(string inputPinCode)
        {
            // The ^ and $ characters are achors that specify that the string should start and end patteen,respectively
            //[1-9] matches any digit from 1 to 9
            //[0-9]{5} matches any digit from 0 to 9 exactly 5 times
            string strRegex = @"(^[1-9][0-9]{5}$)";

            Regex re = new Regex(strRegex);

            // The IsMatch method is used to validate a string or to ensure that a string conforms to a particular pattern.
            if (re.IsMatch(inputPinCode))
                return (true);
            else
                return (false);
        }*/
    }
}
