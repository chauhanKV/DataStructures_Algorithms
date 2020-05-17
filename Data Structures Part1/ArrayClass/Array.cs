using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass
{
    public class Array
    {
        private int[] items;
        private int count;

        public int[] Items { get => items; set => items = value; }

        public Array(int length)
        {
            Items = new int[length];
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(Items[i]);
                
            }
            Console.ReadLine();
        }

        public void insert(int item)
        {

            ResizeIfRequired();

            Items[count++] = item;
        }

        private void ResizeIfRequired()
        {
            if (Items.Length == count)
            {
                int[] newItems = new int[count * 2];
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = Items[i];
                }

                Items = newItems;
            }
        }

        public void removeAt(int index)
        {
            if (index < 0 || index >= count)
                throw new InvalidOperationException();

            for (int i = index; i < count; i++)
            {
                Items[i] = Items[i + 1];
            }
            count--;
        }

        public int indexOf(int value)
        {
            for (int i = 0; i < count; i++)
            {
                if (Items[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        public int Max()
        {
            int max = 0;
            for (int i = 0; i < count; i++)
            {
                if (Items[i] > max)
                    max = Items[i];
            }
            return max;
        }

        public void Reverse()
        {

            int[] newArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = Items[count - i - 1];
            }
            Items = newArray;
        }

        public void insertAt(int item, int index)
        {
            if (index < 0 || index >= count)
                throw new InvalidOperationException();

            ResizeIfRequired();

            for (int i = count; i > index; i--)
            {

                Items[i] = Items[i - 1];
                
            }

            Items[index] = item;
            count++;


        }

        public Array Intersect(Array otherArray)
        {

            Array intersection = new Array(count);

            foreach (int value in Items)
            {
                if (otherArray.indexOf(value) >= 0)
                {
                    intersection.insert(value);
                }
            }
            return intersection;
        }

    }
}
