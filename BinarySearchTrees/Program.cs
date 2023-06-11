using BinarySearchTrees;

namespace DataStructuresinCharp
{
    public class Program
    {
        public static void Main()
        {

            Tree t = new Tree();
            t.Insert(30);
            t.Insert(35);
            t.Insert(50);
            t.Insert(15);
            t.Insert(60);
            t.Insert(40);
            t.Insert(80);
            t.Insert(75);
            t.Insert(65);
            t.Insert(90);
            t.Insert(85);
            Console.WriteLine("Inorder Traversel is: ");
            t.In_order(t.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine("Preorder Traversel is: ");
            t.Pre_order(t.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine("Postorder Traversel is: ");
            t.Post_order(t.ReturnRoot());
        }
    }
}