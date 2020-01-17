using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    public class Stack
    {

        int[] stackstore;
        int stackLength = 0;
        int top = 0;
        int size;

        public Stack(int size)
        {
            stackstore = new int[size];
        }
        public void Push(int item)
        {
            int 
        }

        private int [] GetStacktoPush()
        {
            
        }

        private int CountItem()
        {
            
        }
        public class Node
        {
            public int data;
            public Node next;

            public Node(int value)
            {
                data = value;
                next = null; 
            }
        }
    }
}
