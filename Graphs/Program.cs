using Graphs;

namespace DataStructuresinCharp
{
    public class Program
    {
        public static void Main()
        {

            Graph graph = new Graph(4);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 3);

            graph.PrintAdjacecnyMatrix();

            Console.WriteLine("BFS traversel starting from vertex 1:");
            graph.BFS(1);
            Console.WriteLine("DFS traversel starting from vertex 1:");
            graph.DFS(1);
        }
    }
}