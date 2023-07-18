using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 2, 5, 8 };
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("The sum of array elements:"+sum);
        }
    }
}
