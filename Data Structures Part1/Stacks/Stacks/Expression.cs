using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Expression
    {
        private string input;
        public Expression(string input)
        {
            this.input = input;
        }

        public bool isBalanced()
        {
            Stack<char> str = new Stack<char>();

            foreach (char ch in input.ToCharArray())
            {
                if (ch == '(')
                    str.Push(ch);

                if (ch == ')')
                {
                    if (str.Count == 0) return false;
                    str.Pop();
                }
            }

            return str.Count == 0;
        }
    }
}
