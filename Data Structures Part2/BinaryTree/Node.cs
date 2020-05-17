using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node
    {
        private int value;
        private Node leftChild;
        private Node rightChild;

        public Node(int value)
        {
            this.Value = value;
        }

        public int Value { get => value; set => this.value = value; }
        internal Node LeftChild { get => leftChild; set => leftChild = value; }
        internal Node RightChild { get => rightChild; set => rightChild = value; }
    }
}
