﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    public class Stack
    {
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
