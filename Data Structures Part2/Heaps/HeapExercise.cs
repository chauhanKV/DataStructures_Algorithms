using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    class HeapExercise
    {

        public bool isMaxHeap(int[] array)
        {
            return isThisMaxHeap(array, 0);
        }

        private bool isThisMaxHeap(int[] array, int largestItemIndex)
        {
            if (isRootWithNoChildren(array, largestItemIndex))
                return true;

            if (isRootOnlyWithLeftChild(array, largestItemIndex))
            {
                if (array[largestItemIndex] < leftChild(array, largestItemIndex))
                    return false;
                else
                {
                    largestItemIndex = leftChildIndex(largestItemIndex);

                }
                
            }

            if (isRootWithBothChildren(array, largestItemIndex))
            {
                if (isRootSmallThanItsChildren(array, largestItemIndex))
                    return false;

                largestItemIndex = maxChildIndex(array, largestItemIndex);
            }

            return isThisMaxHeap(array, largestItemIndex);
        }

        private bool isRootWithNoChildren(int[] array, int index)
        {
            return (leftChildIndex(index) > array.Length && rightChildIndex(index) > array.Length);
        }

        private bool isRootWithBothChildren(int[] array, int index)
        {
            return (leftChildIndex(index) < array.Length && rightChildIndex(index) < array.Length);
        }

        private bool isRootOnlyWithLeftChild(int[] array, int index)
        {
            return (leftChildIndex(index) < array.Length && rightChildIndex(index) >= array.Length);
        }

        private int maxChildIndex(int[] array, int index)
        {
            return leftChild(array, index) > rightChild(array, index) ? leftChildIndex(index) : rightChildIndex(index);
        }

        private bool isRootSmallThanItsChildren(int[] array, int index)
        {
            return array[index] < leftChild(array,index) && array[index] < rightChild(array, index);
        }

        
        private int leftChild(int[] array, int index)
        {
            return array[leftChildIndex(index)];
        }

        private int rightChild(int[] array, int index)
        {
            return array[rightChildIndex(index)];
        }

        private int leftChildIndex(int index)
        {
            return (index * 2) + 1;
        }

        private int rightChildIndex(int index)
        {
            return (index * 2) + 2;
        }
    }
}
