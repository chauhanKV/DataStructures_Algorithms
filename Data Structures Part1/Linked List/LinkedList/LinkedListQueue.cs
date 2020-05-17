using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedListQueue
    {
        private Node first;
        private Node last;
        private int count;

        // o(1)
        public void enqueue(int item)
        {
            var node = new Node(item);
            if (first == null)
                first = last = node;
            else
            {
                last.Next = node;
                last = node;
            }
            count++;
        }


        // o(1)
        public int dequeue()
        {
            int removedItem;
            removedItem = first.Value;
            first = first.Next;
            count--;
            return removedItem;

        }

        // o(1)
        public int peek()
        {
            return first.Value;
        }

        public int size()
        {
            return count;
        }

        public bool isEmpty()
        {
            return first == null;
        }
    }
}
