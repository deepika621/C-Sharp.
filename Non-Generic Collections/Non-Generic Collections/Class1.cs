using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Non_Generic_Collections
{
    class Class1
    {
        protected void Button3_Click(object sender, EventArgs e)
        {
            SortedList sl = new SortedList();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");

            foreach (DictionaryEntry d in sl)
            {
                Response.Write(d.Key + " " + d.Value);
                Response.Write("<br>");
            }
        }
    }
}
