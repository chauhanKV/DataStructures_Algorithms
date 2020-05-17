using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class StackWithTwoQueues
    {

        Queue<int> queue1 = new Queue<int>();
        Queue<int> queue2 = new Queue<int>();
        int top;

        public void push(int item)
        {
            queue1.Enqueue(item);
            top = item;
        }

        public int pop()
        {
            if (isEmpty())
                throw new InvalidOperationException();

            if (queue2.Count == 0)
            {
                while (queue1.Count > 1)
                {
                    queue2.Enqueue(queue1.Dequeue());
                }
            }

            var temp = queue1;
            queue1 = queue2;
            queue2 = temp;


            return queue2.Dequeue();
        }

        public int peek()
        {
            return top;
        }

        public int size()
        {
            return queue1.Count;
        }

        public bool isEmpty()
        {
            return (queue1.Count == 0);
        }

        public override string ToString()
        {
            List<int> lst = new List<int>();
            while (queue1.Count != 0)
            {
                lst.Add(queue1.Dequeue());
            }

            return String.Join(",", lst.ToArray());
        }
    }

   
}
