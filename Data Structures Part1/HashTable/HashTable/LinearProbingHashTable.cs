using System;
using System.Linq;

namespace HashTable
{
    class LinearProbingHashTable
    {
        private class KeyValuePair
        {
            private int key;
            private int value;

            public KeyValuePair(int key, int value)
            {
                this.Key = key;
                this.Value = value;
            }

            public int Value { get => value; set => this.value = value; }
            public int Key { get => key; set => key = value; }
        }

        KeyValuePair[] entries = new KeyValuePair[5];
        int count = 0;

        public void put(int key, int value)
        {
            //var hashValue = hash(key);


            //if (entries[hashValue] == 0)
            //    entries[hashValue] = value;
            //else
            //{
            //    int count = 1;
            //    while (entries[hashValue + count] == 0)
            //    {
            //        entries[hashValue + count] = value;
            //        count++;
            //        return;
            //    }
            //    throw new Exception("Array out of index");
            //}

            KeyValuePair entry = getEntry(key);
            if (entry != null)
            {
                entry.Value = value;
                return;
            }

            if (isFull())
                throw new Exception("Array is full");

            entries[getIndex(key)] = new KeyValuePair(key, value);
            count++;

        }

        public void remove(int key)
        {
            int index = getIndex(key);

            if (index == -1 || entries[index] == null)
                return;

            entries[index] = null;
            count--;
        }

        public int size()
        {
            return count;
        }

        public override string ToString()
        {
            return String.Join(",", entries.Select(p => p.ToString()));
        }

        public int? getValue(int key)
        {
            var entry = getEntry(key);
            return entry?.Value;
        }

        private int getIndex(int key)
        {
            int steps = 0;
            while (steps < entries.Length)
            {
                int ind = index(key, steps++);
                KeyValuePair entry = entries[ind];
                if (entry == null || entry.Key == key)
                    return ind;
            }
            return -1;
        }

        private KeyValuePair getEntry(int key)
        {
            int index = getIndex(key);
            return (index >= 0) ? entries[index] : null;
        }

        private int getHashValue(int key)
        {
            return hash(key);
        }

        private bool isFull()
        {
            return count == entries.Length;
        }

        private int index(int key, int i)
        {
            return (hash(key) + i) % entries.Length;
        }

        private int hash(int key)
        {
            return (key % entries.Length);
        }

    }
}
