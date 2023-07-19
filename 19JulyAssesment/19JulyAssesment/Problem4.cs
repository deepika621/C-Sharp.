using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _19JulyAssesment
{
    class Problem4
    {
        public static void CountOccurences()
        {
            string input = "Foxes are omnivorousmammals belonging to several genera of the family Canidae fox.";
            //This Regular Expression matches anything that occurs between the opening and closing greater than and less than symbols.
            string pattern = @"fox(es)?";
            int count = Regex.Matches(input, pattern,RegexOptions.IgnoreCase).Count;
            Console.WriteLine("There are {0} Occurences",count);
        }
    }
}
