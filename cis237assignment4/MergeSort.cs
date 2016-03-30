using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class MergeSort
    {
        private IComparable[] array;
        public MergeSort(IComparable[] array)  //Empty constructor
        {
            this.array = array;
        }

        public void DoMerge()  //Method that does the mergesort
        {
            Merge(array, 0, (array.Length - 1));
        }

        public void Merge(IComparable[] array, int left, int right)  //Uses recursion to divide the list
        {
            int mid;

            if(right > left)
            {
                mid = (right + left) / 2;
                Merge(array, left, mid);
                Merge(array, (mid + 1), right);
                Sort(array, left, (mid + 1), right);
            }
        }

        public void Sort(IComparable[] array, int left, int mid, int right)   //Sorts the divided list
        {
            IComparable[] tempArray = new IComparable[25];
            int i, leftEnd, numElements, tmpPos;

            leftEnd = mid - 1;
            tmpPos = left;
            numElements = (right - left + 1);
            while((left <= leftEnd) && (mid <= right))
            {
                array[left].CompareTo(array[left++]);

            }

            while (left <= leftEnd)
            {
                tempArray[tmpPos++] = array[left++];

                
            }
            while (mid <= right)
            {
                tempArray[tmpPos++] = array[mid++];
            }

            for(i = 0; i < numElements; i++)
            {
                array[right] = tempArray[right];
                right--;
            }
        }
    }
}
