using System.Collections;

namespace DataStructuresinCharp
{
    public class Program
    {
        public static void Main()
        {

            Hashtable my_hashtable1 = new Hashtable();

            my_hashtable1.Add("A1", "Welcome");
            my_hashtable1.Add("A2", "to");
            my_hashtable1.Add("A3", "GeeksforGeeks");

            Console.WriteLine("Key and Value pairs from my_hashtable1:");

            foreach (DictionaryEntry ele1 in my_hashtable1)
            {
                Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
            }

            my_hashtable1.Remove("A2");

            Console.WriteLine("Key and Value pairs from my_hashtable1:");

            foreach (DictionaryEntry ele1 in my_hashtable1)
            {
                Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
            }
            Console.WriteLine(my_hashtable1.Contains("A3"));
            Console.WriteLine(my_hashtable1.ContainsValue("geeks"));

            my_hashtable1.Clear();
            Console.WriteLine("Key and Value pairs from my_hashtable1:");

            foreach (DictionaryEntry ele1 in my_hashtable1)
            {
                Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
            }


            Hashtable my_hashtable2 = new Hashtable() {
                                      {1, "hello"},
                                          {2, 234},
                                        {3, 230.45},
                                         {4, null}};

            Console.WriteLine("Key and Value pairs from my_hashtable2:");

            foreach (var ele2 in my_hashtable2.Keys)
            {
                Console.WriteLine("{0}and {1}", ele2,
                                my_hashtable2[ele2]);
            }
        }
    }
}