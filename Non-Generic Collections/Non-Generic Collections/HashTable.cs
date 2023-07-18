using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Non_Generic_Collections
{
    public void HashTable(object sender, EventArgs e)
    {
        Hashtable ht = new Hashtable();
        ht.Add("ora", "oracle");
        ht.Add("vb", "vb.net");
        ht.Add("cs", "cs.net");
        ht.Add("asp", "asp.net");

        foreach (DictionaryEntry d in ht)
        {
            Response.Write(d.Key + " " + d.Value);
            Response.Write("<br>");
        }
    }
}
