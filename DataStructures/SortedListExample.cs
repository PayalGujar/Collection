using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class SortedListExample
    {
        public static void Main(string[] args)
        {
            SortedList st= new SortedList();
            st.Add("101", "HR");
            st.Add("202", "Management");

            foreach(DictionaryEntry item in st)
            {
                Console.WriteLine($"{item.Key}={item.Value}");
            }
            
            
           

        }
    }
}
