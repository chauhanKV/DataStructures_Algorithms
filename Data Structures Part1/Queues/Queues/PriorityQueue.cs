using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class PriorityQueue
    {
        private int[] items;
        private int count;

        public PriorityQueue(int capacity)
        {
            items = new int[capacity];
        }

        public void addItems(int item)
        {
            ResizeArray();

            int i;
            for (i = (count - 1); i >= 0; i--)
            {
                if (items[i] > item)
                    items[i + 1] = items[i];
                else
                {
                   
                    break;
                }
            }
            items[i + 1] = item;
            count++;
        }

        private void ResizeArray()
        {
            if (isFull())
            {
                int[] newArray = new int[items.Length * 2];
                for (int i = 0; i < items.Length; i++)
                {
                    newArray[i] = items[i];
                }

                items = newArray;
            }
        }

        private bool isFull()
        {
            return (items.Length == count);
        }

        public int remove()
        {
            if (isEmpty()) throw new Exception("Queue is empty. Cannot remove");
            return items[--count];
        }

        private bool isEmpty()
        {
            return count == 0;
        }

        public override string ToString()
        {
            return String.Join(",", items.Select(p => p.ToString()).ToArray());
        }
    }
}
