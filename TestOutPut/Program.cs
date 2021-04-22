using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;
using LinkedListNew;
using Graphs;
using Modified = Graphs.DetectCycle;

namespace TestOutPut
{
    class Program
    {
        static void Main(string[] args)
        {
            TestModifiedGraph();
            TestGraph();
            //MyList myList = new MyList();
            //myList.AddToBegining(1);
            //myList.AddToBegining(2);
            //myList.AddToBegining(3);
            //myList.AddToBegining(4);
            //myList.AddToBegining(5);
            //myList.Print();

            //myList.PrintReverse();

            //var result= myList.Search( 3);
            //var result2 = myList.Search(2);
            //Console.WriteLine(result);
            //Console.WriteLine(result2);
        }

        static void TestGraph()
        {
            var graph = new Graph();
            var  airports = "PHX BKK OKC JFK LAX MEX EZE HEL LOS LAP LIM";

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
           
            var lines = graph.adjList.Select(kvp => kvp.Key + "=> [" + String.Join(", ",kvp.Value) +"]");
            foreach (var item in lines)
            {
                Console.WriteLine(item);
            }

             graph.GetPaths("PHX", "BKK");
            
        }

        static void TestModifiedGraph()
        {
           var graph = new Modified.Graph();

           var a=new Modified.Vertex("1");
           var b=new Modified.Vertex("2");
           var c=new Modified.Vertex("3");
           var d=new Modified.Vertex("4");
            
            
            graph.AddVertex(a);
            graph.AddVertex(b);
            graph.AddVertex(c);
            graph.AddVertex(d);

            graph.AddEdge(a, b);
            graph.AddEdge(b, c);
            graph.AddEdge(c, d);
            graph.AddEdge(d, a);


           
            var result=graph.HasCycle(a);

            graph.PrintDFS();
        }

    }
}
