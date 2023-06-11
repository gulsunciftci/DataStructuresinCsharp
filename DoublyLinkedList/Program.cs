using DoublyLinkedList;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DataStructuresinCharp
{
    public class Program
    {

        public static Node head;
        public static void Main()
        {
            // Start with the empty list
            head= null;

            
            push(6);
            //Added 6 to the beginning of the linked list

            push(7);
            //Added 7 to the beginning of the linked list


            push(1);
            //Added 1 to the beginning of the linked list



            Console.WriteLine("Doubly Linked List:");
            printList(head);

            InsertAfter(head, 10);
            //Added 10 after the first node of the linked list

            append(9);
            //Added 9 to the end of the linked list

            Console.WriteLine("\nDoubly Linked List:");
            printList(head);

            Console.WriteLine("\nEnter the data you want to search in the linked list: ");
            int searchvalue = int.Parse(Console.ReadLine());
            Console.WriteLine(search(searchvalue));

            Console.WriteLine("\nnine deleted:");
            deleteNode(ref head, 9);
            printList(head);

            Console.WriteLine("\nData in 2. index deleted:");
            deleteNodePosition(ref head, 2);
            printList(head);

            Console.WriteLine("\nvalue at index 0: " + GetNth(0));

            Console.WriteLine("\nfirst data at the end of linked list:");
            printNodeFromLast(1);


            Console.WriteLine("\nDoubly Linked List Reversed:");
            ReverseList();
            printList(head);

            Console.WriteLine("\nLinked list deleted:");
            deleteList();
            printList(head);

        }
        public static void push(int new_data)
        {

            // Allocate node
            Node new_node = new Node(new_data);

            // Make next of new node as
            // head and previous as null
            new_node.next = head;
            new_node.prev = null;

            // Change prev of head node to
            // the new node
            if (head!= null)
                head.prev = new_node;

            // Move the head to point to
            // the new node
            head = new_node;
        }
        public static void InsertAfter(Node prev_Node, int new_data)
        {
            // Check if the given prev_node is NULL
            if (prev_Node == null)
            {
                Console.WriteLine(
                    "The given previous node cannot be NULL ");
                return;
            }

            // 1. allocate node
            // 2. put in the data
            Node new_node = new Node(new_data);

            // 3. Make next of new node as next of prev_node
            new_node.next = prev_Node.next;

            // 4. Make the next of prev_node as new_node
            prev_Node.next = new_node;

            // 5. Make prev_node as previous of new_node
            new_node.prev = prev_Node;

            // 6. Change previous of new_node's next node
            if (new_node.next != null)
                new_node.next.prev = new_node;
        }
        public static void append(int new_data)
        {
            // 1. allocate node
            // 2. put in the data
            Node new_node = new Node(new_data);

            Node last = head; /* used in step 5*/

            // 3. This new node is going
            //  to be the last node, so
            // make next of it as NULL
            new_node.next = null;

            // 4. If the Linked List is empty,
            // then make the new node as head
            if (head == null)
            {
                new_node.prev = null;
                head = new_node;
                return;
            }

            // 5. Else traverse till the last node
            while (last.next != null)
                last = last.next;

            // 6. Change the next of last node
            last.next = new_node;

            // 7. Make last node as previous of new node
            new_node.prev = last;
        }

        public static bool search(int x)
        {
            Node current = head; // Initialize current
            while (current != null)
            {
                if (current.data == x)
                    return true; // data found
                current = current.next;
            }
            return false; // data not found
        }
        public static void ReverseList()
        {
            Node prev = null, current = head, next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }
        public static void deleteNode(ref Node head, int val)
        {
            // Check if list is empty or we reach at the end of the list.
            if (head == null)
            {
                Console.WriteLine("Element not present in the list");
                return;
            }

            // If current node is the node to be deleted
            if (head.data == val)
            {
                Node t = head;

                // If it's start of the node head node points to second node
                head = head.next;

                // Delete the node
                t = null;
                return;
            }

            // Recursively call the function on the next node
            deleteNode(ref head.next, val);
        }

        public static void deleteNodePosition(ref Node head, int position)
        {

            // If linked list is empty
            if (head == null)
                return;

            // Store head node
            Node temp = head;

            // If head needs to be removed
            if (position == 0)
            {

                // Change head
                head = temp.next;
                return;
            }

            // Find previous node of the node to be deleted
            for (int i = 0; temp != null && i < position - 1;
                 i++)
                temp = temp.next;

            // If position is more than number of nodes
            if (temp == null || temp.next == null)
                return;

            // Node temp->next is the node to be deleted
            // Store pointer to the next of node to be deleted
            Node next = temp.next.next;

            // Unlink the deleted node from list
            temp.next = next;
        }

        public static int GetNth(int index)
        {
            Node current = head;
            int count = 0; /* index of Node we are
                        currently looking at */
            while (current != null)
            {
                if (count == index)
                    return current.data;
                count++;
                current = current.next;
            }

            /* if we get to this line, the caller was asking
            for a non-existent element so we assert fail */

            return 0;
        }

        public static void printNodeFromLast(int N)
        {
            int len = 0;
            Node temp = head;

            //count the number of nodes in Linked List
            while (temp != null)
            {
                temp = temp.next;
                len++;
            }

            // check if value of N is not more than length of
            // the linked list
            if (len < N)
                return;

            temp = head;

            //get the (len-N+1)th node from the beginning
            for (int i = 1; i < len - N + 1; i++)
                temp = temp.next;

            Console.WriteLine(temp.data);
        }

        public static void deleteList()
        {
            head = null;
        }

        static void printList(Node node)
        {
            Node last = null;

            while (node != null)
            {

                // Print the data
                Console.Write(" " + node.data + " ");
                last = node;
                node = node.next;
            }
           
        }
    }
}