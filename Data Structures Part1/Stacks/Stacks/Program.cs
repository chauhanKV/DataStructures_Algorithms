using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {

            Reverse str = new Reverse();
            var value = str.StringReverse("abcdefg");
            Console.WriteLine(value);
            

            Expression exp = new Expression(")1+2(");
            var isBalanced = exp.isBalanced();
            Console.WriteLine(isBalanced);


            MyStack stack = new MyStack(4);
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);

            stack.pop();
            stack.push(-2);
            stack.push(-5);
            stack.pop();

            Console.WriteLine(stack.minStack());
            Console.WriteLine(stack.ToString());


            TwoStack twoStack = new TwoStack(10);
            twoStack.push1(10);
            twoStack.push2(20);
            twoStack.push1(30);
            twoStack.push1(40);
            twoStack.push2(50);
            twoStack.push1(60);
            twoStack.push2(70);

            twoStack.pop1();
            twoStack.pop2();
            twoStack.pop1();
            //twoStack.pop2();
            //twoStack.pop2();
            //twoStack.pop2();
            //twoStack.pop2();
            //twoStack.pop2();
            Console.WriteLine(twoStack.ToString());

            // ----------------Stacks with 2 queues ----------------//

            StackWithTwoQueues sq = new StackWithTwoQueues();
            sq.push(10);
            sq.push(20);
            sq.push(30);
            sq.push(40);
            sq.push(50);

            

            Console.WriteLine("Poping out: " + sq.pop());
            Console.WriteLine("Poping out: " + sq.pop());
            //Console.WriteLine("Poping out: " + sq.pop());
            //Console.WriteLine("Poping out: " + sq.pop());
            //Console.WriteLine("Poping out: " + sq.pop());

            Console.WriteLine("Size of StackWithTwoQueue is: " + sq.size());

            Console.WriteLine("Peek: Last value inserted in StackWithTwoQueue is: " + sq.peek());
            Console.WriteLine(sq.ToString());
            Console.ReadLine();
        }
    }
}
