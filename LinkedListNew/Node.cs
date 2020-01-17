using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.LinkedList
{
    //This class represents a node in Linked List
    public class Node
    {
       public object data = null;
       public Node next = null;
    }


    public class NodeList
    {
        Node Head =null;
        Node Tail;

        public void AdLast(object data)
        {
            Node newitem = new Node();
            newitem.data = data;

            if (Head == null)
            {
                Head = newitem;
            }
            else
            {
                Node current = Head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newitem;
            }
        }
        public void AddFirst()
        { }

        public void ReadAll()
        { }


    }
}
