using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class ArrayQueue
    {
        private int[] queue;
        private int rear;
        private int front;
        private int count;
        public ArrayQueue(int capacity)
        {
            queue = new int[capacity];
        }

        public void enqueue(int item)
        {
            if (count == queue.Length) throw new IndexOutOfRangeException();

            queue[rear] = item;
            rear = (rear + 1) % queue.Length;
            count++;
        }

        public int dequeue()
        {
            var item = queue[front];
            queue[front] = 0;
            front = (front + 1) % queue.Length;
            count--;
            return item;
        }

        public override string ToString()
        {
            //int[] content = new int[count];
            //Array.ConstrainedCopy(queue, 0, content, 0, count);
            return String.Join(",", queue.Select(p => p.ToString()).ToArray());
        }
    }
}
