namespace DataStructuresinCharp
{
    public class Program
    {
        public static void Main()
        {

            int[] intArray = new int[6];
            
            for(int i=0;i<intArray.Length;i++)
            {
                intArray[i] = i+1;
            }
            
            intArray[0] = 20;
            PrintArrayTekBoyutlu(intArray);

            string[,] strings = new string[5, 3]
            {
                {"istanbul ","ankara ","izmit" },
                {"balıkesir","konya ","kırıkkale" },
                {"antalya","adana ","mersin " },
                {"rize","trabzon ","samsun " },
                {"izmir","muğla ","manisa " }
            };

            PrintArrayIkiBoyutlu(strings);

        }
        public static void PrintArrayTekBoyutlu(int[] array)
        {
            int n = 0;
            while (n != array.Length)
            {

                Console.Write(array[n] + " ");
                n++;
            }
            Console.Write("\n");
        }
        public static void PrintArrayIkiBoyutlu(string[,] array)
        {
            
            for(int i=0; i <= array.GetUpperBound(0);i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
               
                        Console.Write(array[i, j] + " ");
               
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}