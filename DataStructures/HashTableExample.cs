using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class HashTableExample
    {
        public static void Main(string[] args)
        {
            Hashtable ht= new Hashtable();
            ht.Add("91", "IND");
            ht.Add("41", "USA");
            ht.Add("51", "END");
            ht.Remove("41");
            foreach(DictionaryEntry en in ht) 
            { 
                Console.WriteLine($"{en.Key}={en.Value}");
            }
        }
    }
}
