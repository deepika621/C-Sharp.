using System;

namespace Review2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            int count = 0;
            foreach (var ch in str)
            {
                count++;
            }
            Console.WriteLine("Length of the string:"+ count);
        }
    }
}
