using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class DoublelyLinkedList
    {
        private class Node
        {
            private int value;
            private Node previous;
            private Node next;

            public Node(int item)
            {
                Value = item;
            }

            public int Value { get => value; set => this.value = value; }
            private Node Previous { get => previous; set => previous = value; }
            private Node Next { get => next; set => next = value; }
        }



    }
}
