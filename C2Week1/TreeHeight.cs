using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2Week1
{
    public class Node
    {
        public int value;
        public List<Node> Children;

        public Node(int data)
        {
            value = data;
            Children = new List<Node>();
        }
    }
    public class MyTree
    {
        public Node root;
        public void CreateTree(int[] input)
        {
            int[] a = new int[5];
            Node[] nodeArray = new Node[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                nodeArray[i] = new Node(i);
            }
                
            for (int i = 0; i < input.Length; i++)
            {
                int parent = input[i];
                if (parent == -1)
                {
                    root = nodeArray[i];
                }
                else
                {
                    nodeArray[parent].Children.Add(nodeArray[i]);
                }
            }

        }

        public int CalculateTreeHeight(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                if (root.Children.Count == 0)
                    return 1;
                else if (root.Children.Count == 1)
                    return 1 + CalculateTreeHeight(root.Children[0]);
                else 
                {
                    int maxHeight = 0;
                    for (int i = 0; i < root.Children.Count; i++)
                    {
                        var childHeight = CalculateTreeHeight(root.Children[i]);
                        if (childHeight > maxHeight)
                            maxHeight = childHeight;
                    }
                    return 1 + maxHeight;
                }
            }

        }

        //public int Height()
        //{
        //    if (root == null)
        //        return 0;
        //    else if (root.Children.Count == 0)
        //        return 1;
        //    else
        //    {
        //        foreach (var child in root.Children)
        //        {
                    
        //        }  
        //    }
        //}
    }
}
