using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class HashTableExercise
    {
        public int GetMostFrequent(int[] array)
        {
            Dictionary<int, int> items = new Dictionary<int, int>();

            if (array.Length == 0)
                throw new Exception("Array is empty");

            for (int i = 0; i < array.Length; i++)
            {
                if (items.ContainsKey(array[i]))
                    items[array[i]]++;
                else
                    items.Add(array[i], 0);
            }

            int max = -1;
            int key = array[0];
            foreach (KeyValuePair<int,int> item in items)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    key = item.Key;
                }
            }
            return key;
        }


        public int countPairsWithDiff(int[] array, int k)
        {
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = 0; j < array.Length; j++)
            //    {
            //        if ((array[i] - array[j]) == k)
            //        {

            //            if (!unique.Contains(new Dictionary<int, int> { { array[i], array[j] } }))
            //            {
            //                items.Add(array[i], array[j]);
            //                unique.Add(items);
            //            }
            //        }
            //    }
            //}

            //return unique.Count();

            HashSet<int> sets1 = new HashSet<int>();
            HashSet<int> sets2 = new HashSet<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (!sets1.Contains(array[i]))
                    sets1.Add(array[i]);

                if (!sets2.Contains(array[i]))
                    sets2.Add(array[i]);
            }

            int count = 0;
            foreach (int item in sets2)
            {
                if (sets1.Contains(item + k))
                    count++;
                if (sets1.Contains(item - k))
                    count++;
                
                
                sets1.Remove(item);
            }

            return count;
        }


        public int[] twoSum(int[] array, int target)
        {
            //var indices = new int[2];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = 0; j < array.Length; j++)
            //    {
            //        if ((array[i] + array[j]) == target)
            //        {
            //            indices[0] = array[i];
            //            indices[1] = array[j];
            //        }
            //    }
            //}

            //return indices;

            Dictionary<int, int> items = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                int complement = target - array[i];
                if (items.ContainsKey(complement))
                {
                    int value;
                    items.TryGetValue(complement, out value);
                    return new int[] { value, i };
                }
                items.Add(array[i], i);
            }
            return null;
        }


    }
}
