using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
       public int num;
       public Node next;

        public Node(int n)
        {
            num = n;
        }
        public Node()
        {          
        }
    }
    public class SinglyLinkedList
    {
        private Node Head;
        private Node Tail;
        private int Count; // To keep track of all the elements in the list


        public SinglyLinkedList()
        {
            Head = new Node();
            Tail = Head;
        }

        //void AddToFront(int value)
        //{
        //    Head = n;
        //    if (CurrentElement != null)
        //    { n.next = CurrentElement; }
        //    else
        //    {
        //        CurrentElement = n;
        //        CurrentElement.next = null;
        //    }

        //}


        public void AddtoFront(int value)
        {
            Node temp = new Node();
            temp = Head;
            Head = new Node(value);
            Head.next = temp.next;
            Count++;
            if (Count == 0)
            {
                Head.num = value;
                Head.next = null;
                Tail = Head;
                Count++;

            }
            else
            {
                Node n = new Node { num = value };
                n.next = Head;
                Head = n;
                Count++;
            }
        }

        public void AddToLast(int value)
        {
            Node n = new Node { num = value, next = null };
            Tail.next = n;
            Tail = n;
            Count++;
        }

        public void AddInTheMiddle(int value)
        {

        }

        public void PrintAllElements()
        {
            Console.Write("Head-->");
            Node n = Head;
            if (n == null)
            {
                Console.Write( " NULL ");
                
            }
            //else
            // n.next.PrintAllElements(); 
            
        }

        public void RemoveFromStart()
        {
            Head = Head.next;
        }

        public void RemoveFromEnd()
        {
            Node temp = Head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }

            temp.next = null;
        }

        public void RemoveByValue(int value)
        {
            Node temp = Head;
            while (temp.next != null)
            {

                if (temp.num == value)
                {
                    // If its the first element of the linked list 
                    if (temp == Head)
                    {
                        RemoveFromStart();
                        break;
                    }
                    else if (temp.next == null)
                    {
                        RemoveFromEnd();
                        break;
                    }
                    else
                    {

                    }

                }
            }
        }



    }



   

 }




