using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListNew
{
    // Add an item 
    // Search an item
    /* Linked list : single chain of nodes 
     * Provides two pointers : Head pointer and Tail Pointer 
     * Supports Operations : Add, Remove, Find, Enumerate, Count
     * ADD--> Add to Start, End to End
     */
    public class Node
    {
        public int num;
        public Node next;

        public Node(int i)
        {
            num = i;
            next = null;
        }

        public void Print()
        {
            Console.Write("[" + num + "]->");
            if (next != null)
            {
                next.Print();
            }

        }

        public void PrintReverse()
        {
            if (next == null)
            {
                Console.Write(" NULL ");
            }
            else
            {
                next.PrintReverse();
                Console.Write(" ["+next.num+"] ");
            }
        }

        public void AddSorted(int data)
        {
            if (this.next == null)
            {
                Node node = new Node(data);
            }
            else if (this.next.num > data)
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                this.next.AddSorted(data);
            }
        }

        public void AddToEnd(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }

      
        
    }

    public class MyList
    {
        public Node headNode;
        public MyList()
        {
            headNode = null;
        }

        public void AddToEnd(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                headNode.AddToEnd(data);
            }
        }

        public void AddToBegining(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                var temp = new Node(data);
                temp.next = headNode;
                headNode = temp;
            }
        }

        public void Print()
        {
            if (headNode != null)
            {
                headNode.Print();
            }
        }

        public void PrintReverse()
        {
            if (headNode != null)
            {
                headNode.PrintReverse();
            }

        }

        public bool Search(int value)
        {
            if (headNode == null)
            {
                return false;
            }
            else
            {
                if (headNode.num == value)
                {
                    return true;
                }
                else
                {
                    this.headNode = headNode.next;
                    return Search(value);
                }
            }
        }
    }
}
