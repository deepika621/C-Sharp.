using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    class Username
    {
        public static void UN()
        {
            string[] names = { "Deepika" ,"Sirisha"};
            string pattern = @"^[A-Z]{1}[a-z]{3,}$";
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
