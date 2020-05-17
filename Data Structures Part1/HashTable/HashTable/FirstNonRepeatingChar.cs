using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class FirstNonRepeatingChar
    {
        IDictionary<char, int> dict;
        public string FindFirstNonRepeatingChar(string input)
        {
            dict = new Dictionary<char, int>();
            var chars = input.ToCharArray();
            foreach (char ch in chars)
            {
                if (dict.ContainsKey(ch))
                    dict[ch]++;
                else
                    dict.Add(ch, 1);
            }

            foreach (char ch in chars)
            {
                if (dict[ch] == 1)
                    return ch.ToString();
            }
            return "(no character found)";
        }

        public override string ToString()
        {
            return (String.Join(",", dict.Select(p => p.ToString()).ToArray()));
        }
    }
}
