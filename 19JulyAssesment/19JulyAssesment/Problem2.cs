using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _19JulyAssesment
{
    class Problem2
    {
        public static void Sequence()
        {
            string input = "life_is_beautiful";

            string pattern = @"^[a-z]+(_[a-z]+)*$";
            Match match = Regex.Match(input, pattern);
            if(match.Success)
            {
                Console.WriteLine("Match Found:" + match.Value);
            } 
            else { Console.WriteLine("No Match Found.");
            }
        }
    }
}
