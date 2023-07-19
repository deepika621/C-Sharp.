using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    class FirstnameLastname
    {
        public static void FN_LN()
        {
            string[] names = {"Kasarla Deepika","Geddam Shirisha","Madhugan Sindhuja","Elon Musk","P.Akshitha Reddy"};
            string pattern = @"^[A-Z][a-z]*\s[A-Z][a-z]*(\s[A-Z][a-z]*)?$";
            Regex regex = new Regex(pattern);
            foreach (string name in names)
            {
                if (regex.IsMatch(name))
                {
                    Console.WriteLine(name + " is a valid name format");
                }
                else
                {
                    Console.WriteLine(name + " is not a valid name format");
                }
            }
        }
    }
}
