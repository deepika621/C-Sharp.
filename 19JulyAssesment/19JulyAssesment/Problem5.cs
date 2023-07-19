using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _19JulyAssesment
{
    class Problem5
    {
        public static void FileName()
        {
            string[] fileNames = {"image.jpg","picture.png","photo.gif","document.docx","data.csv"};
            string pattern = @"\.(jpg|jpeg|png|gif)$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            foreach (string fileName in fileNames)
            {
                if (regex.IsMatch(fileName))
                {
                    Console.WriteLine(fileName);
                }
            }
        }

    }
}
