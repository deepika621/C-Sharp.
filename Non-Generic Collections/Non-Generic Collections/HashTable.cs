using System;
using System.Collections;

namespace Non_Generic_Collections
{
    class HT
    {
        public  void HashTable()
        {
            Hashtable ht = new Hashtable();
            ht.Add("ora", "oracle");
            ht.Add("vb", "vb.net");
            ht.Add("cs", "cs.net");
            ht.Add("asp", "asp.net");

            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + " " + d.Value);
                //Response.Write("<br>");
            }
        }
    }
}
