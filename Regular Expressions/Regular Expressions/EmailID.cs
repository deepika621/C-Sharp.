// C# program to validate the Email ID using Regular Expressions
using System;
using System.Text.RegularExpressions;

class RE
{

    // Main Method
    public static void EmailID()
    {

        // Input strings for Match valid E-mail address.
        string[] str = {"happy@gmail.com",
                "happygmail.com",
                            "@gmail.com"};

        foreach (string s in str)
        {
            Console.WriteLine("{0} {1} a valid E-mail address.", s,
                                isValidEmail(s) ? "is" : "is not");
        }

    }

    // Method to check the Email ID
    public static bool isValidEmail(string inputEmail)
    {

        // This Pattern is use to verify the email
        string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

        Regex re = new Regex(strRegex, RegexOptions.IgnoreCase);

        if (re.IsMatch(inputEmail))
            return (true);
        else
            return (false);
    }
}
