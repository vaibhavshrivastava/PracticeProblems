using System;

namespace PriorityQueue
{
    public class Class1
    {
        /*
         * Priority Queue: Where you add elements to the heap and unlike queue where be extract 
         * first element in, instead we extract the element with the hightest priority.
         * 
         * Main Operations: Insert, ExtractMax, Remove(item), GetMaxPriority,ChangePriority
         * If we use array to implememt PQueue, then inserting a given element will take O(n)
         * Whearas if we use LinkedList then finding the right position to insert an element will take O(n)
         * 
         * Hence, we use a differnt Data structure called Binary Heap that provides O(Logn) time for both insert and Extract Max Operations
         * 
         * 
         *    Binary Heap--> It is a binary tree where the value of each node is at least the value of its children
         * 
         * Insert :-->    Attach a new node to any leaf 
         *                This may violate the heap property (value of each node is at least the value of its children)
         *                So we use ShiftUp():
         *                While the parent of the newly added node is smaller than the node, we swap them until the property of Binary heap is staisfied.
         *                Running time O(Tree Height)
         * 
         * ExtractMax:--> Max value lives the root of Binary Heap.
         *                So first, we swap the root with any leaf, then remove the leaf that contains the root
         *                Then since we have a incorrect element present at the root,
         *                We use ShiftDown()
         *                Starting from the root, we replace the root node with larger child node until the heap property is satisfied. 
         *                Running time O(Tree Height)
         *                
         * ChangePriority:--> 
         * 
         * Remove :-->    Find the element that we want to remove
         *                Call changePriority function to change the priority of that Node to Infinity
         *                Call extractMax function to remove the node with priority infinity 
         *                Running time O(Tree Height)
         *                
         * A Binary Tree is complete if all its levels are filled except possibily the last one which is filled from left to right
         * 
         * */
    }
}
