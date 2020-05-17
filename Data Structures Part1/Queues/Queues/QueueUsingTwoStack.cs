using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class QueueUsingTwoStack
    {
        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();

        public void enqueue(int item)
        {
            stack1.Push(item);
        }

        public int dequeue()
        {
            if (stack1.Count == 0 && stack2.Count == 0)
                throw new InvalidOperationException();

            if (stack2.Count == 0)
            {
                while (stack1.Count != 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            return stack2.Pop();

        }
    }
}
