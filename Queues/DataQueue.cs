using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    public class DataQueue
    {
        public Node head;
        public Node tail;

        public bool IsEmpty()
        {
            return head == null;
        }
        public int Peek()
        {
            if (head != null)
            {
                return head.data;
            }
            return -1;
        }
        public void Add(int data)
        {
            Node node = new Node(data);
            if (tail != null)
            {
                tail.next = node;
            }
            tail = node;
            if (head == null)
            {
                head = node;
            }
        }
        public int Remove()
        {
            int data = -1;
            if (head != null)
            {
                data = head.data;
                head = head.next;
            }
            else
            {
                tail = null;
            }

            return data;
        }
        public void printList()
        {
            Node n = this.head;
            while (n != null)
            {

                Console.Write(n.data + " ");
                n = n.next;
            }
            Console.Write("\n");
        }
    }
}
