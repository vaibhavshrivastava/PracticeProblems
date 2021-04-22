using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs.DetectCycle
{
    // Detect a cycle in a graph
    public class Vertex
    {
        public string Value; 
        public HashSet<Vertex> AdjList; // also called neighbours in some implementations   // public Dictionary<Vertex, int> adjList;  // For weighted graph
        public bool exploring = false;
        public bool visited = false;
        public Vertex(string value)
        {
            this.Value = value;
            this.AdjList = new HashSet<Vertex>();
        }

        public void addNeighbour(Vertex adjacent)
        {
            this.AdjList.Add(adjacent);
        }

    }
    public class Graph
    {
        //public Dictionary<string, Dictionary<string,int>> adjList = new Dictionary<string, Dictionary<string,int>>(); // Weighted graph

        List<Vertex> vertices;

        public Graph()
        {
            vertices = new List<Vertex>();
        }

        public void AddVertex(Vertex vertex)
        {
            this.vertices.Add(vertex);
        }

        public void AddEdge(Vertex from, Vertex to)
        {
            from.addNeighbour(to);
        }

        public bool HasCycle(Vertex start)
        {
            start.exploring = true;
            foreach (var neighbour in start.AdjList)
            {
                if (neighbour.exploring)
                {
                    return true;
                }
                else if (!neighbour.visited && HasCycle(neighbour))
                    return true;
            }

            start.exploring = false;
            start.visited = true;
            return false;
        }


        public void PrintDFS()
        {
            
            foreach (var item in vertices)
            {
                if(!item.visited)
                DFS(item);
            }
        }


        private void DFS(Vertex start)
        {
            Console.WriteLine(start.Value);
            start.visited = true;
            var neighbours = start.AdjList;
            if (neighbours.Count == 0)
            {
                return;
            }
            foreach (var neighbour in start.AdjList)
            {
                if (!neighbour.visited)
                {
                    DFS(neighbour);
                }
            }
        }



    }
}
