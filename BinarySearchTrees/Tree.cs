using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTrees
{
    public class Tree
    {
        public Node root;

        public Tree()
        {
            root = null;
        }
        public Node ReturnRoot()
        {
            return root;
        }
        public void Insert(int x)
        {
            Node newnode = new Node();
            newnode.value = x;
            if (root == null)
            {
                root = newnode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (x < current.value)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newnode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newnode;
                            return;
                        }
                    }
                }
            }

        }
        public void Pre_order(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.value + " ");
                Pre_order(root.left);
                Pre_order(root.right);
            }
        }
        public void In_order(Node root)
        {
            if (root != null)
            {
                In_order(root.left);
                Console.WriteLine(root.value + " ");
                In_order(root.right);
            }
        }
        public void Post_order(Node root)
        {
            if (root != null)
            {
                Post_order(root.left);
                Post_order(root.right);
                Console.WriteLine(root.value + " ");

            }
        }
    }
}
