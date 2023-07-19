using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace _19JulyAssesment
{
    class Problem3
    {
        public static void HTMLTags()
        {
            string input = "<p>The<code>Regex</code> is a compiled representation of a regular expression.</p>";
            //This Regular Expression matches anything that occurs between the opening and closing greater than and less than symbols.
            string pattern = @"<.*?>";
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach(Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

        }
    }
}
