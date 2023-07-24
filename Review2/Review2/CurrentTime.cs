using System;
using System.Collections.Generic;
using System.Text;

namespace Review2
{
    class CurrentTime
    {
        public static void FindCurrentTime()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("The current Time is:"+now.ToString("hh:mm:ss:tt"));
        }
    }
}
