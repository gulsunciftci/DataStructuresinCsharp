using Stacks;
using System;
using System.Collections;

namespace DataStructuresinCharp
{
    public class Stacks
    {
        public static void Main()
        {

            DataStack s = new DataStack();
            s.Push(0);
            s.Push(8);
            s.Push(11);
            s.Push(9);
            s.Pop();

            s.printList();
            Console.WriteLine(s.Peek());
            Console.WriteLine(s.IsEmpty());
        }
    }
}