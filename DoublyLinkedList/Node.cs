using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class Node
    {
        public int data;
        public Node next;
        public Node prev;

        public Node(int d) { data = d; next = null; }
    }
}
