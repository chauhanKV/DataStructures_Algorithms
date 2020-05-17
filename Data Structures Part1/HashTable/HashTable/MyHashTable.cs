using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class MyHashTable
    {
        private class KeyValuePair
        {
            private int key;
            private string value;

            public KeyValuePair(int key, string value)
            {
                this.Key = key;
                this.Value = value;
            }

            public string Value { get => value; set => this.value = value; }
            public int Key { get => key; set => key = value; }
        }

        private LinkedList<KeyValuePair>[] entries = new LinkedList<KeyValuePair>[5];

        public void put(int key, string value)
        {
            int index = hash(key);

            if (entries[index] == null)
            {
                entries[index] = new LinkedList<KeyValuePair>();

            }

            var bucket = entries[index];

            foreach (KeyValuePair lst in bucket)
            {
                if (lst.Key == key)
                {
                    lst.Value = value;
                    return;
                }
            }
            bucket.AddLast(new KeyValuePair(key, value));
        }

        public string get(int key)
        {
            var index = hash(key);
            var bucket = entries[index];
            if (bucket != null)
            {
                foreach (KeyValuePair lst in bucket)
                {
                    if (lst.Key == key)
                        return lst.Value;
                }
            }
            return null;
        }

        public void remove(int key)
        {
            var index = hash(key);
            var bucket = entries[index];

            if (bucket == null)
                throw new Exception("No entries found");

            foreach (KeyValuePair lst in bucket)
            {
                if (lst.Key == key)
                {
                    bucket.Remove(lst);
                    return;
                }
            }

            throw new Exception("No entry found matching key");
        }

        private int hash(int key)
        {
            return key % (entries.Length);
        }
    }
}
