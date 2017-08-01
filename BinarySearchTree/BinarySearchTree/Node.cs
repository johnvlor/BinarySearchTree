using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        public int number;
        public Node leftChild;
        public Node rightChild;

        public Node(int number)
        {
            this.number = number;
            leftChild = null;
            rightChild = null;

        }

        public void DisplayNode(Node n)
        {
            if (n == null)
                return;

            DisplayNode(n.leftChild);
            Console.Write(n.number + " ");
            DisplayNode(n.rightChild);
        }
    }
}
