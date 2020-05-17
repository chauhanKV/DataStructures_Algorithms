using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class QueueReverser
    {
        private Queue<int> queue;

        public QueueReverser()
        {
            queue = new Queue<int>();
        }

        public void add(int item)
        {
            queue.Enqueue(item);
        }

        public void ReverseTillK(int position)
        {
            int index = 0;
            Stack<int> stack = new Stack<int>();
            Queue<int> newQueue = new Queue<int>();
            while (index < position)
            {
                stack.Push(queue.Dequeue());
                index++;
            }

            while (stack.Count != 0)
            {
                // newQueue.Enqueue(stack.Pop());
                queue.Enqueue(stack.Pop());
            }

            //while (queue.Count != 0)
            //{
            //    newQueue.Enqueue(queue.Dequeue());
            //}

            //queue = newQueue;

            for (int i = 0; i < (queue.Count - position); i++)
            {
                queue.Enqueue(queue.Dequeue());
            }

        }
    }
}
