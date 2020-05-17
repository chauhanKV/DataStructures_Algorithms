using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTrees
{
    class AVLNode
    {
        private AVLNode leftChild;
        private AVLNode rightChild;
        private int value;
        private int height;

        public AVLNode(int value)
        {
            this.value = value;
        }

        public int Value { get => value; set => this.value = value; }
        public int Height { get => height; set => height = value; }
        internal AVLNode LeftChild { get => leftChild; set => leftChild = value; }
        internal AVLNode RightChild { get => rightChild; set => rightChild = value; }
    }
}
