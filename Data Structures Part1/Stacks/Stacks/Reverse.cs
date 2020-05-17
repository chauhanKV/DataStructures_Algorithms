using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Reverse
    {

        public string StringReverse(string input)
        {
            Stack<char> s = new Stack<char>();

            foreach(char ch in input.ToCharArray())
            {
                s.Push(ch);
            }

            StringBuilder reverse = new StringBuilder();
            while (s.Count != 0)
            {
                reverse.Append(s.Pop());
            }

            return reverse.ToString();
          
        }
    }
}
