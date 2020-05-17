using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class FirstRepeatedCharacter
    {

        HashSet<int> set = new HashSet<int>();
        public char FindFirstRepeatedCharacter(string input)
        {
            foreach (char ch in input.ToCharArray())
            {
                if (set.Contains(ch))
                    return ch;

                set.Add(ch);
            }
            return char.MinValue;
        }
    }
}
