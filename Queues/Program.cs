using Queues;
using System;
using System.Collections;

namespace DataStructuresinCharp
{
    public class Queues
    {
        public static void Main()
        {

            DataQueue q = new DataQueue();
            q.Add(1);
            q.Add(8);
            q.Add(7);
            q.Remove();

            q.printList();
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.IsEmpty());
        }
    }
}