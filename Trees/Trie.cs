using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class TrieNode
    {
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        public bool endOfWord;
    }

    public class Tries
    {
        TrieNode root;

        public void CreateRoot()
        {
            root = new TrieNode();
        }

        public void Add(char[] chars)
        {
            TrieNode tempRoot = root;
            int total = chars.Count() - 1;
            for (int i = 0; i < chars.Count(); i++)
            {
                TrieNode newTrie;
                if (tempRoot.children.Keys.Contains(chars[i]))
                {
                    tempRoot = tempRoot.children[chars[i]]; // new root will be node pointed by the key(char) at index i 
                }
                else
                {
                    newTrie = new TrieNode();
                    if (i == (chars.Count() - 1))
                    {
                        newTrie.endOfWord = true;
                    }
                    tempRoot.children.Add(chars[i], newTrie);
                    tempRoot = newTrie;
                }
            }
        }


        public bool FindPrefix(char[] chars)
        {
            TrieNode tempNode = root;
            for (int i = 0; i < chars.Count(); i++)
            {
                if (tempNode.children.Keys.Contains(chars[i]))
                {
                    tempNode = tempNode.children[chars[i]];
                }
                else
                {
                    return false;
                }
               
            }
            return true ;
        }



        public bool Search(char[] chars)
        {
            TrieNode tempNode = root;
            return SearchRecursively(root, chars, 0);
        }

        private bool SearchRecursively(TrieNode current, char[] chars,int index)
        {
            if (index == chars.Count())
            {
                return current.endOfWord;
            }

            else
                current = current.children[chars[index]];
            {
                if (current == null)
                return false;
            }
            return SearchRecursively(current, chars, index + 1);
        }


        public void Delete(char[] chars)
        {
            TrieNode tempNode = root;
            DeleteRecursively(root, chars,0);
        }

        private bool DeleteRecursively(TrieNode current, char[] chars,int index)
        {
            if (index == chars.Count())
            {
                if (current.endOfWord==false)
                {
                    return false;
                }

                current.endOfWord = false;
                return current.children.Count == 0;
            }

            TrieNode node = current.children[chars[index]];
            if (node == null)
            {
                return false;
            }
            bool shouldDelete = DeleteRecursively(node, chars, index + 1);


            if (shouldDelete)
            {
                current.children.Remove(chars[index]);
                return current.children.Count == 0;
            }
            return false;
        }

    }
}
