using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class MyStack
    {
        private int[] stackArray;
        private int count;
        public MyStack(int length)
        {
            stackArray = new int[length];
        }

        public void push(int item)
        {
            ResizeIfRequired();

            stackArray[count++] = item;
        }

        private void ResizeIfRequired()
        {
            if (stackArray.Length == count)
            {
                int[] newArray = new int[count * 2];
                for (int i = 0; i < stackArray.Length; i++)
                {
                    newArray[i] = stackArray[i];
                }
                stackArray = newArray;
            }
        }

        public int pop()
        {
            if (count == 0)
                throw new System.InvalidOperationException();

            return stackArray[--count];
          
        }

        public int peek()
        {
            if (count == 0)
                throw new System.InvalidOperationException();

            return stackArray[count - 1];
        }

        public bool isEmpty()
        {
            return stackArray.Length == 0;

        }

        public override string ToString()
        {
            int[] content = new int[count];
            Array.ConstrainedCopy(stackArray, 0, content, 0, count);
            return String.Join(",", content.Select(p => p.ToString()).ToArray());
        }

        public int minStack()
        {
            int min = stackArray[0];
            for (int i = 0; i < count; i++)
            {
                if (stackArray[i] < min)
                    min = stackArray[i];
            }

            return min;
        }
    }
}
