using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Graph
    {
        private int Vertex;
        private List<Int32>[] adjacecny;

        public Graph(int v)
        {
            Vertex = v;
            adjacecny = new List<int>[v];
            for (int i=0;i<v;i++)
            {
                adjacecny[i] = new List<int>();
            }
        }
        public void AddEdge(int v,int w)
        {
            adjacecny[v].Add(w);
        }
        public void BFS(int s)
        {
            bool[] visited = new bool[Vertex];
            Queue<int> queue = new Queue<int>();
            visited[s] = true;
            queue.Enqueue(s);

            while (queue.Count != 0)
            {
                s = queue.Dequeue();
                Console.WriteLine("next-->" + s);

                foreach (int next in adjacecny[s])
                {
                    if (!visited[next])
                    {
                        visited[next] = true;
                        queue.Enqueue(next);
                    }
                }
            }
        }
        public void DFS(int s)
        {
            bool[] visited = new bool[Vertex];
            Stack<int> stack = new Stack<int>();
            visited[s] = true;
            stack.Push(s);

            while (stack.Count != 0)
            {
                s = stack.Pop();
                Console.WriteLine("next-->" + s);

                foreach (int next in adjacecny[s])
                {
                    if (!visited[next])
                    {
                        visited[next] = true;
                        stack.Push(next);
                    }
                }
            }
        }
        public void PrintAdjacecnyMatrix()
        {
            for (int i=0;i<Vertex;i++)
            {
                string s = "";
                foreach (var k in adjacecny[i])
                {
                    s = s + (k + ",");
                }
                s = s.Substring(0, s.Length - 1);
                s =s+"]";
                Console.WriteLine(i+":["+s);
                Console.WriteLine();

            }
        }
    }
}
