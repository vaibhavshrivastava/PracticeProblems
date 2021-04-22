using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs.DetectCycles
{
    public class Vertex
    {
       public int value;
       public bool isVisited;
       public bool isExplored;
       public List<Vertex> adjList;

        public Vertex(int value)
        {
            this.value = value;
            this.adjList = new List<Vertex>();
        }
    }


    public class Graph
    {
        public List<Vertex> vertices;
        public void AddVertex(Vertex vertex)
        {
            this.vertices.Add(vertex);
        }

        public void AddEdge(Vertex from, Vertex to)
        {
            from.adjList.Add(to);
        }

    }


  
}
