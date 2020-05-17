using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class TwoStack
    {

        private int[] items;
        private int top1;
        private int top2;

        public TwoStack(int capacity)
        {
            items = new int[capacity];
            top1 = -1;
            top2 = capacity;
        }

        public void push1(int value)
        {
            if (isFull1()) throw new System.StackOverflowException();

            items[++top1] = value;
        }

        public int pop1()
        {
            if (isEmpty1()) throw new System.NullReferenceException();

            return items[top1--];
        }

        private bool isEmpty1()
        {
            return top1 == -1;
        }

        private bool isFull1()
        {
            return top1 + 1 == top2;
        }

        //---------------------------------------------//

        public void push2(int value)
        {
            if (isFull2()) throw new System.StackOverflowException();

            items[--top2] = value;
        }

        public int pop2()
        {
            if (isEmpty2()) throw new System.NullReferenceException();

            return items[top2++];
        }

        private bool isEmpty2()
        {
            return top2 == items.Length;
        }

        private bool isFull2()
        {
            return top1 + 1 == top2;
        }

        public override string ToString()
        {
            int[] content = new int[items.Length];
            Array.ConstrainedCopy(items, 0, content, 0, items.Length);
            return String.Join(",", content.Select(p => p.ToString()).ToArray());
        }
    }
}
