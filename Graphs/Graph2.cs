using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph2
{

    public class Graph
    {
        public Dictionary<string, List<string>> adjList = new Dictionary<string, List<string>>();


        public void AddVertex(string airport)
        {
            adjList.Add(airport, new List<string>());
        }

        public void AddEdge(string source, string destination)
        {
            if (adjList.ContainsKey(source))
            {
                adjList[source].Add(destination);
            }
            else
                adjList.Add(source, new List<string> { destination });

            if (adjList.ContainsKey(destination))
            {
                adjList[destination].Add(source);
            }
            else
                adjList.Add(destination, new List<string> { source });

        }

        //BFS
        public void GetPaths(string airport1, string airport2)
        {
            var queue = new Queue<string>();
            queue.Enqueue(airport1);
            var visited = new HashSet<string>();
            while (queue.Count > 0)
            {
                var airport = queue.Dequeue();
                var connectedAirports = adjList[airport];

                foreach (var port in connectedAirports)
                {
                    if (port == airport2)
                    {
                        Console.WriteLine(" Found it ");
                    }
                    if (!visited.Contains(port))
                    {
                        queue.Enqueue(port);
                        visited.Add(port);
                        Console.WriteLine(port);
                    }
                }


            }
        }


        public void PrintDFS()
        {
            HashSet<string> visited = new HashSet<string>();
            foreach (var item in adjList)
            {
                if (!visited.Contains(item.Key))
                {
                    DFSRecursive(item.Key, ref visited);
                    Console.WriteLine();
                }

            }

        }

        private void DFSRecursive(string startnode, ref HashSet<string> visited)
        {
            Console.Write(startnode + "-->" );
            visited.Add(startnode);
            var neighbours = adjList[startnode];
            if (neighbours.Count == 0)
                return;
            foreach (var item in neighbours)
            {
                if (!visited.Contains(item))
                {
                    DFSRecursive(item, ref visited);
                }
            } 

        }

        private void DFSWithStack(string startnode)
        {
            HashSet<string> visited = new HashSet<string>();
            var stack = new Stack<string>();
            stack.Push(startnode);

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                // Visited the current Node
                Console.WriteLine(current);
                // Visted
                visited.Add(current);
                var neighbours = adjList[startnode];
                foreach (var item in neighbours)
                {
                    if (!visited.Contains(item))
                    {
                        stack.Push(item);
                    }
                }
                
            }



        }
       


    }
}
