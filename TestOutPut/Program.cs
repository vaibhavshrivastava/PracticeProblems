using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace TestOutPut
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList ln = new SinglyLinkedList();
            ln.AddtoFront(3);
            ln.AddtoFront(2);
            ln.AddtoFront(1);
            ln.AddToLast(4);
            ln.RemoveFromEnd();
            ln.PrintAllElements();
            Console.ReadLine();


        }
    }
}
