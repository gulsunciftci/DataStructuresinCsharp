using SinglyLinkedList;
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
            head = null;

            push(1);

            push(5);
            //Added 5 to the beginning of the linked list



            insertAfter(head, 3);
            //Added 3 after the first node of the linked list

            append(8);
            //Added 8 to the end of the linked list


            Console.WriteLine("Linked List:");
            printList();


            Console.WriteLine("\nEnter the data you want to search in the linked list: ");
            int searchvalue = int.Parse(Console.ReadLine());
            Console.WriteLine(search(searchvalue));

            Console.WriteLine("Linked List Reversed:");
            ReverseList();
            printList();


            Console.WriteLine("Eight deleted:");
            deleteNode(ref head, 8);
            printList();


            Console.WriteLine("Data in 1. index deleted:");
            deleteNodePosition(ref head, 1);
            printList();

            Console.WriteLine("value at index 0:" + GetNth(0));

            Console.WriteLine("first data at the end of linked list:");
            printNodeFromLast(1);


            Console.WriteLine("Linked list deleted:");
            deleteList();
            printList();



        }
        public static void printList()
        {
            Node n = head;
            while (n != null)
            {

                Console.Write(n.data + " ");
                n = n.next;
            }
            Console.Write("\n");
        }
        public static void push(int new_data)
        {

            Node new_node = new Node(new_data);

            /*Make next of new Node as head */
            new_node.next = head;

            /*Move the head to point to new Node */
            head = new_node;
        }


        public static void insertAfter(Node prev_node, int new_data)
        {
            /*Check if the given Node is null */
            if (prev_node == null)
            {
                Console.WriteLine("The given previous" +
                                  " node cannot be null");
                return;
            }

            Node new_node = new Node(new_data);

            /*Make next of new Node as
                  next of prev_node */
            new_node.next = prev_node.next;

            /*make next of prev_node as new_node */
            prev_node.next = new_node;
        }


        public static void append(int new_data)
        {
            /*Allocate the Node &
            Put in the data
            Set next as null */
            Node new_node = new Node(new_data);

            /* If the Linked List is empty,
            then make the new node as head */
            if (head == null)
            {
                head = new Node(new_data);
                return;
            }

            /*This new node is going to be the last node, 
                so make next of it as null */
            new_node.next = null;

            /*Else traverse till the last node */
            Node last = head;
            while (last.next != null)
                last = last.next;

            /*Change the next of last node */
            last.next = new_node;
            return;
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


        public static void deleteList()
        {
            head = null;
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

    }



}