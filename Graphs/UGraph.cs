using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//UGraph stands for undirected graph
namespace Graphs.UGraphs
{
    public class Vertex
    {
        public int Value;
        public List<Vertex> adjList;
        public bool visited;
        public Vertex parent;
        public Vertex(int value)
        {
            this.Value = value;
            this.adjList = new List<Vertex>();
        }
    }
    public class UGraph
    {
        List<Vertex> Vertices = new List<Vertex>();
        public void AddVertex(Vertex vertex)
        {
            Vertices.Add(vertex);
            
        }
        public void AddEdge(Vertex from, Vertex to)
        {
            from.adjList.Add(to);
            to.adjList.Add(from);
        }


        public void PrintDFS()
        {
            var visited = new HashSet<Vertex>();
            foreach (var item in Vertices)
            {
                if (!visited.Contains(item))
                {
                    DFS(item, ref visited);
                    Console.WriteLine();
                }
            }
            
        }

        public void DFS(Vertex start, ref HashSet<Vertex> visited)
        {
            Console.Write(start.Value + "<-->");
            visited.Add(start);
            var neighbours = start.adjList;
            if (neighbours.Count == 0)
                return;

            foreach (var item in neighbours)
            {
                if (!visited.Contains(item))
                {
                    DFS(item, ref visited);
                }
            }
        }

        public bool HasCycle()
        {
            foreach (var item in Vertices)
            {
                if (!item.visited)
                {
                   var cycle=HasCycleUtil(item, null);
                    if (cycle)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public bool HasCycleUtil(Vertex start, Vertex parent)
        {
            start.visited = true;
            var neighbours = start.adjList;
            start.parent = parent;
            foreach (var item in neighbours)
            {
                if (item.visited == true & item != parent)
                {
                    return true;
                }
                else if (!item.visited)
                {
                    if (HasCycleUtil(item, start))
                        return true;
                }
            }
            return false;
            
        }


    }
}
