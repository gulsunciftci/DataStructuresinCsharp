using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    public class DataStack
    {
        public Node top;
        public bool IsEmpty()
        {
            return top == null;
        }
        public int Peek()
        {
            if (top != null)
            {
                return top.data;
            }
            return -1;
        }
        public void Push(int data)
        {
            Node node = new Node(data);
            node.next = top;
            top = node;
        }
        public int Pop()
        {
            if (top != null)
            {
                int data = top.data;
                top = top.next;
                return data;
            }
            return -1;
        }
        public void printList()
        {
            Node n = this.top;
            while (n != null)
            {

                Console.Write(n.data + " ");
                n = n.next;
            }
            Console.Write("\n");
        }
    }
}
