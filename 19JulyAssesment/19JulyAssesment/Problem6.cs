using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _19JulyAssesment
{
    class Problem6
    {
        public static void WebsiteAddressFormat()
        {
            string[] urls = {"https://www.google.com","http://www.example.com","www.yahoo.com",
                "https://www.microsoft.com/en-us/default.aspx","http://localhost:8080"};
            string pattern = @"^(https?://)?([\da-z.-]+)\.([a-z.]{2,6})([/\w.-]*)*/?$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            foreach (string url in urls)
            {
                if (regex.IsMatch(url))
                {
                    Console.WriteLine(url + " is a valid URL format");
                }
                else
                {
                    Console.WriteLine(url + " is not a valid URL format");
                }
            }
        }
    }
}
