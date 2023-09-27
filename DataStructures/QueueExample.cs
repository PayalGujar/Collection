using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class QueueExample
    {
        public static void Main(string[] args)
        {
            Queue q1 = new Queue();
            q1.Enqueue(10);
            q1.Enqueue(20);
            q1.Enqueue(30);
            q1.Enqueue(40);
            q1.Dequeue();//It will remove 1st element Added in the queue

            foreach(object item in q1) { Console.WriteLine(item); }

            
        }
    }
}
