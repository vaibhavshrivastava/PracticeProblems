using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;
using LinkedListNew;

namespace TestOutPut
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList();
            myList.AddToBegining(1);
            myList.AddToBegining(2);
            myList.AddToBegining(3);
            myList.AddToBegining(4);
            myList.AddToBegining(5);
            myList.Print();

            myList.PrintReverse();

            var result= myList.Search( 3);
            var result2 = myList.Search(2);
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}
