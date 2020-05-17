using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        private int value;
        private Node next;

        public Node(int value)
        {
            this.Value = value;
        }

        public int Value { get => value; set => this.value = value; }
        public Node Next { get => next; set => next = value; }
    }
}
