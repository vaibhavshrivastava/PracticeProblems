using System;

namespace LinkedList
{
    public class SinglyLinkedList
    {
        private Node Head;
        private Node Tail;
        private int Count;


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
            Tail =n;
            Count++;
        }

        public void AddInTheMiddle(int value)
        {

        }

        public void PrintAllElements()
        {
            Console.Write("Head-->");
            Node n = Head;
            while (n != null)
            {
                Console.Write(n.num+"-->");
                n = n.next;
            }
            Console.Write("NULL");
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
                temp=temp.next;
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


    public class Node
    {
        public int num;
        public Node next;
    }



}
