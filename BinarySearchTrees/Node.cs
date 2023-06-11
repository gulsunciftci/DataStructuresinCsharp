using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTrees
{
    public class Node
    {
        public int value;
        public Node left;
        public Node right;

        public void show()
        {
            Console.WriteLine("[$value]");

        }
    }
}
