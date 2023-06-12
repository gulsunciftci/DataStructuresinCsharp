using System.Collections;

namespace DataStructuresinCharp
{
    public class Program
    {
        public static void Main()
        {
            ArrayList student = new ArrayList();
            student.Add("Jackson");
            student.Add(5);
            student.Add(8);

            PrintArrayList(student);
            Console.WriteLine("**********");
            Console.WriteLine("First element: " + student[0]);

            student[1] = "Styles";
            Console.WriteLine("**********");
            PrintArrayList(student);

            student.Remove("Jackson");
            Console.WriteLine("**********");
            PrintArrayList(student);
        }
        public static void PrintArrayList(ArrayList arrayList)
        {
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
        }
    }
}