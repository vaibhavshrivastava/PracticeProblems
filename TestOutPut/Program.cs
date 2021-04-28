using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;
using LinkedListNew;
using Graph2;

namespace TestOutPut
{
    // Class to test the output on the console window 
    class Program
    {
        static void Main(string[] args)
        {

            TestGraphMatrix();
         
        }

        public static void TestGraphMatrix()
        {
            var testObj = new TestGraphMatrix();
            testObj.Test_ConnectedComponents();
        }
        public static void TestGraphOutput()
        {
            var testObj = new TestGraphOutput();
            testObj.Test_Undirected_Graph_HasCycle();
        }

        public static void TestLinkedListOutput()
        {
            var testObj = new TestLinkedListOutPut();
            testObj.TestPrintReverse();
        }

    }
}
