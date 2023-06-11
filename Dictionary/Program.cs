using System.Collections;

namespace DataStructuresinCharp
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<int, string> My_dict1 =
                       new Dictionary<int, string>();

         
            My_dict1.Add(1123, "Welcome");
            My_dict1.Add(1124, "to");
            My_dict1.Add(1125, "GeeksforGeeks");

            foreach (KeyValuePair<int, string> ele1 in My_dict1)
            {
                Console.WriteLine("{0} and {1}",
                          ele1.Key, ele1.Value);
            }
            Console.WriteLine();

            My_dict1.Remove(1123);

            foreach (KeyValuePair<int, string> ele1 in My_dict1)
            {
                Console.WriteLine("{0} and {1}",
                          ele1.Key, ele1.Value);
            }
            Console.WriteLine();

            Console.WriteLine(My_dict1.ContainsKey(1122));
            Console.WriteLine(My_dict1.ContainsValue("to"));

            My_dict1.Clear();
            foreach (KeyValuePair<int, string> ele1 in My_dict1)
            {
                Console.WriteLine("{0} and {1}",
                          ele1.Key, ele1.Value);
            }
            Console.WriteLine();


            Dictionary<string, string> My_dict2 =
                    new Dictionary<string, string>(){
                                  {"a.1", "Dog"},
                                  {"a.2", "Cat"},
                                {"a.3", "Pig"} };

            foreach (var ele2 in My_dict2.Keys)
            {
                Console.WriteLine("{0} and {1}", ele2, My_dict2[ele2]);
            }

        }
    }
}