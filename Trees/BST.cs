using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BSTnode
    {
        int _value;
        BSTnode leftChild;
        BSTnode rightChild;

        public BSTnode(int value)
        {
            _value = value;
            leftChild = null;
            rightChild = null;
        }

        public void InsertNode(int value)
        {
            if (this._value >= value && this.leftChild != null)
            {
                this.leftChild.InsertNode(value);
            }
            else if (this._value >= value)
            {
                this.leftChild = new BSTnode(value);
            }

            else if (this._value < value && this.rightChild != null)
            {
                this.rightChild.InsertNode(value);
            }
            else
                this.rightChild = new BSTnode(value);
        }


        public void FindNode(int value)
        {
            if (value > this._value && this.rightChild != null)
            {
                this.rightChild.FindNode(value);
            }
            else if (value < this._value && this.leftChild != null)
            {
                this.leftChild.FindNode(value);
            }
            else if (value == this._value)
            {
                Console.WriteLine("Value is Present");
            }

            else { Console.WriteLine("Value Not Present"); }
        }

        public  void DeleteNode(int value)
        {
            if (value < this._value && this.leftChild != null)
            {
                this.leftChild.DeleteNode(value);
            }

            
        }

    }
}
