using Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G2=Graph1;
using G1=Graph2;
using Graphs.UGraphs;

namespace TestOutPut
{
    class TestGraphOutput
    {

        public void TestGraph()
        {
            var graph = new G1.Graph();
            var airports = "PHX BKK OKC JFK LAX MEX EZE HEL LOS LAP LIM";

            string[][] routes =
                 {
                   new string [] {"PHX", "LAX"},
                   new string [] {"PHX", "JFK"},
                   new string [] {"JFK", "OKC"},
                   new string [] {"JFK", "HEL"},
                   new string [] {"JFK", "LOS"},
                   new string [] {"MEX", "LAX"},
                   new string [] {"MEX", "BKK"},
                   new string [] {"MEX", "LIM"},
                   new string [] {"MEX", "EZE"},
                   new string [] {"LIM", "BKK"}
                 };
            foreach (var airport in airports.Split(' '))
            {
                graph.AddVertex(airport);
            }

            foreach (var route in routes)
            {

                graph.AddEdge(route[0], route[1]);
            }

            graph.PrintDFS();

            var lines = graph.adjList.Select(kvp => kvp.Key + "=> [" + String.Join(", ", kvp.Value) + "]");
            foreach (var item in lines)
            {
                Console.WriteLine(item);
            }

            graph.GetPaths("PHX", "BKK");
        }

        public void TestModifiedGraph()
        {
            var graph = new G2.Graph();

            var a = new G2.Vertex("1");
            var b = new G2.Vertex("2");
            var c = new G2.Vertex("3");
            var d = new G2.Vertex("4");


            graph.AddVertex(a);
            graph.AddVertex(b);
            graph.AddVertex(c);
            graph.AddVertex(d);

            graph.AddEdge(a, b);
            graph.AddEdge(b, c);
            graph.AddEdge(c, d);
            graph.AddEdge(d, a);



            var result = graph.HasCycle(a);

            graph.PrintDFS();
        }

        public void TestGetConnectedComponents()
        {
            var graph = new G2.Graph();
            var a = new G2.Vertex("1");
            var b = new G2.Vertex("2");
            var c = new G2.Vertex("3");
            var d = new G2.Vertex("4");
            var e = new G2.Vertex("5");
            var f = new G2.Vertex("6");
            var g = new G2.Vertex("7");
            var h = new G2.Vertex("8");


            graph.AddVertex(a);
            graph.AddVertex(b);
            graph.AddVertex(c);
            graph.AddVertex(d);
            graph.AddVertex(e);
            graph.AddVertex(f);
            graph.AddVertex(g);
            graph.AddVertex(h);



            graph.AddEdge(a, b);
            graph.AddEdge(b, c);
            graph.AddEdge(c, d);
            graph.AddEdge(d, a);

            graph.AddEdge(e, f);
            graph.AddEdge(f, h);
            graph.AddEdge(e, g);

            var count=graph.GetConnectedComponent(); 




        }

        public void Test_Undirected_Graph_DFS()
        {
            UGraph undiredted = new UGraph();


            var a = new Vertex(1);
            var b = new Vertex(2);
            var c = new Vertex(3);
            var d = new Vertex(4);

            var e = new Vertex(5);
            var f = new Vertex(6);

            undiredted.AddVertex(a);
            undiredted.AddVertex(b);
            undiredted.AddVertex(c);
            undiredted.AddVertex(d);
            undiredted.AddVertex(e);
            undiredted.AddVertex(f);


            undiredted.AddEdge(a,b);
            undiredted.AddEdge(b,c);
            undiredted.AddEdge(c,d);
            undiredted.AddEdge(d,a);

            undiredted.AddEdge(e, f);

            undiredted.PrintDFS();


        }


        public void Test_Undirected_Graph_HasCycle()
        {
            UGraph undiredted = new UGraph();
            var a = new Vertex(1);
            var b = new Vertex(2);
            var c = new Vertex(3);
            var d = new Vertex(4);

            var e = new Vertex(5);
            var f = new Vertex(6);
            var g = new Vertex(7);

            undiredted.AddVertex(a);
            undiredted.AddVertex(b);
            undiredted.AddVertex(c);
            undiredted.AddVertex(d);
            undiredted.AddVertex(e);
            undiredted.AddVertex(f);

            undiredted.AddEdge(a, b);
            undiredted.AddEdge(b, c);
            undiredted.AddEdge(c, d);
            undiredted.AddEdge(g, e);
            undiredted.AddEdge(e, f);
            undiredted.AddEdge(g, f);

            var result = undiredted.HasCycle();
        }
    }
}
