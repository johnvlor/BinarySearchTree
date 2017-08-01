using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        private Node root;

        public Node Root
        {
            get { return root; }
            set { root = value; }
        }

        public BinarySearchTree()
        {
            root = null;
        }

        public void Add(int number)
        {
            Node temp = new Node(number);
            if (Root == null)
            {
                Root = temp;
            }
            else
            {
                Node currentNode = Root;
                while (currentNode != null)
                {
                    Node parentNode = currentNode;
                    if (number < currentNode.number)
                    {
                        currentNode = currentNode.leftChild;
                        if (currentNode == null)
                        {
                            parentNode.leftChild = temp;
                        }
                    }
                    else
                    {
                        currentNode = currentNode.rightChild;
                        if (currentNode == null)
                        {
                            parentNode.rightChild = temp;
                        }
                    }
                }
            }
        }

        public bool Find(int number)
        {
            Node currentNode = Root;

            if (currentNode.number == number)
            {
                return true;
            }
            else
            {
                while (currentNode.number != number)
                {
                    if (currentNode.number > number)
                    {
                        currentNode = currentNode.leftChild;
                    }
                    else
                    {
                        currentNode = currentNode.rightChild;
                    }

                    if (currentNode == null)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public void Display()
        {
            Root.DisplayNode(Root);
        }
    }
}
