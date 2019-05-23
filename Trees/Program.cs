using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class Program
    {
        static void Main(string[] args)
        {
            BSTnode bst = new BSTnode(15);
            bst.InsertNode(10);
            bst.InsertNode(8) ;
            bst.InsertNode(12);
            bst.InsertNode(20);
            bst.InsertNode(17);
            bst.InsertNode(25);
            bst.InsertNode(19);


            bst.FindNode(25);
        }
    }

    public class BinaryTree
    {
        int value;
        BinaryTree rightChild;
        BinaryTree leftChild;

        public BinaryTree(int value)
        {
            this.value = value;
            this.rightChild = null;
            this.leftChild = null;
        }

        public void InsertLeft(int value)
        {
            if (this.leftChild == null)
            {
                this.leftChild = new BinaryTree(value);
            }
            else
            {
                var newNode = new BinaryTree(value);
                newNode.leftChild = this.leftChild;
                this.leftChild = newNode; 
            }
        }

        public void InsertRight(int value)
        {
            if (this.rightChild == null)
            {
                this.rightChild = new BinaryTree(value);
            }
            else
            {
                var newNode = new BinaryTree(value);
                newNode.rightChild = this.rightChild;
                this.rightChild = newNode;
            }
        }

        public void PreOrder(BinaryTree bt)
        {
            Console.WriteLine(bt.value);
            if (bt.leftChild != null)
            {
                PreOrder(bt.leftChild);
            }

            if (bt.rightChild != null)
            {
                PreOrder(bt.rightChild);
            }
        }

    }

}


