using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListNew
{
    public class MiddleElement
    {
        Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        public int GetMiddleElement()
        {
            Node slow_ptr = head;
            Node fast_ptr = head;

            if (head != null)
            {
                while (fast_ptr != null && fast_ptr.next != null)
                {
                    fast_ptr = fast_ptr.next.next;
                    slow_ptr = slow_ptr.next;
                }
            }
            return slow_ptr.data;
          
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        public void PrintList()
        {
            Node tnode = head;
            while (tnode.next != null)
            {
                Console.WriteLine(tnode.data);
                tnode = tnode.next;
            }
        
            
        }

        
        
    }


}
